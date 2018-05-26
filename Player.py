import os
import sys
import random
import numpy as np
import json
from helper import *
from data import *

from datetime import datetime
from datetime import timedelta
from World import World


class Player: 
	def __init__(self, name, save_file=None):

		self.save_file = save_file
		self.sites = world_sites

		if os.path.isfile(save_file):
			# load saved data
			with open(save_file) as input:
				save_data = json.load(input)
				self.name = save_data['name']
				self.wuxue = save_data['wuxue']
				self.is_away = save_data['is_away']
				self.is_home = save_data['is_home']
				self.at_door_step = save_data['at_door_step']
				self.bank = save_data['bank']
				if save_data['arrive_time'] == "":
					self.arrive_time = None
				else:
					self.arrive_time = gt(save_data['arrive_time'])
				destination_name = save_data['destination'] 
				if destination_name in self.sites.keys():
					self.destination = self.sites[destination_name]
				else:
					self.destination = None
			input.close()
		else: 
			self.name = name
			self.wuxue = ['普通拳']
			self.is_away = 0
			self.is_home = 1
			self.at_door_step = 0
			self.bank = 1000
			
			self.arrive_time = None
			self.destination = None

		
		
	def choose_one_wuxue(self):

		return self.wuxue[0]

	def set_off(self, cash):

		if (self.is_away):
			return -1

		self.bank -= cash
		cash = cash
		curr_site = self.sites['牛家村']
		travel_finished = 0
		travel_time = 60
		while (not travel_finished):
			rdm = int(random.uniform(0, len(curr_site.paths.keys())))
			next_site_name = list(curr_site.paths.keys())[rdm]
			next_site = self.sites[next_site_name]
			if curr_site.paths[next_site_name] <= cash:
				cash -= curr_site.paths[next_site_name]
				travel_time += int(np.random.normal(300, 20))
				curr_site = next_site
			else: 
				travel_finished = 1
			if (len(curr_site.paths.keys())==0):
				travel_finished = 1

		# print (curr_site.site_name)
		currtime = datetime.now()

		self.arrive_time = currtime + timedelta(0, travel_time)
		self.destination = curr_site
		self.is_away = 1
		self.is_home = 0

		# print (currtime)
		# print (self.arrive_time)
	def arrive_home(self):
		self.arrive_time = None
		self.is_away = 0
		self.is_home = 1
		self.at_door_step = 0
		dest = self.destination.site_name
		earning = int(np.random.normal(60, 20))
		self.bank += earning
		return dest, earning, genearl_acts[ random.randrange(len(genearl_acts))]

	def refresh(self):
		if (self.arrive_time is not None):
			currtime = datetime.now()

			if self.arrive_time < currtime:
				self.at_door_step = 1

	def save_game(self):
		print ('正在保存游戏。')
		with open(self.save_file, 'w', encoding='utf-8') as output:
			save_dict= {}
			save_dict['name'] = self.name
			save_dict['wuxue'] = self.wuxue
			save_dict['is_away'] = self.is_away
			save_dict['is_home'] = self.is_home
			save_dict['at_door_step'] = self.at_door_step
			save_dict['bank'] = self.bank
			if self.arrive_time is None:
				save_dict['arrive_time'] = ""
			else:
				save_dict['arrive_time'] = self.arrive_time.isoformat()
			if self.destination is None:
				save_dict['destination'] = None
			else:
				save_dict['destination'] = self.destination.site_name
			
			json.dump(save_dict, output)

		output.close()

		print ('保存成功。')
		print ('即将退出游戏。')