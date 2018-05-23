import os
import sys
import time
import random

class Player: 
	def __init__(self, name, saved_file=None):

		if os.path.isfile(saved_file):
			# load saved data
			self.dummy = 0
		else: 
			self.wuxue = ['普通拳']
			self.is_away = 0
			self.is_home = 1
			self.at_door_step = 0
			self.bank = 100
			self.arrive_time = None

	def choose_one_wuxue(self):

		return self.wuxue[0]

	def set_off(self, cash):
		self.bank -= cash
		rdm = random.uniform(1, 100)


	def refresh(self):
		if (self.arrive_time is not None):
			currtime = time.time()


	def save_game(self):
		with open(saved_file, 'w', encoding='utf-8') as output:
			a = 50
		output.close()