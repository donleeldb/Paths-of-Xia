import os
import sys

from Player import Player

def print_menu(player):
	print ('-'*28 + '菜单' + '-'*28)
	# print ('')
	# print ('')
	# print ('')
	print ('输入积蓄范围内的金额后，'+player.name+'将启程下次江湖游历。')
	print ('输入 -1 查看' + player.name +'已掌握的武功。')
	print ('输入 -2 刷新' + player.name +'的状态')
	print ('输入 0 保存并退出游戏')


if __name__ == '__main__':
	
	if (len(sys.argv) != 2):
		print("Please specify your character name. ")
		exit()

	char_name = sys.argv[1]
	save_path = "./saved/" + char_name + ".json"

	player = Player(char_name, save_path)

	game_end = 0

	while (not game_end):

		player.refresh()
		
		print ('\n\n\n\n'+'='*28 + '游戏' + '='*28)

		if (player.at_door_step): 
			dest, earn, act = player.arrive_home()
			print (char_name + '游历回来啦。这次旅程最远去到了')
			print (char_name + '这次旅程最远去到了' + dest + '。 ')
			print ('这一路上，' + char_name + act + str(earn) + '碎银带回家。')
			continue
			
		elif (player.is_away):
			print (char_name + "出门游历去了。请耐心等待。。。")
 
		elif (player.is_home):
			print (char_name + "正在家中修炼" + player.choose_one_wuxue() + "。") 
		print (char_name + "的积蓄有" + str(player.bank) + "碎银。" + "如果你准备好了，可以为" + char_name + "准备下次出门的盘缠。")
		
		# print ( player.world.world_map.sites.keys())

		cmd_accepted = 0

		print_menu(player)

		while ( not cmd_accepted ):
			cmd = input("指令：")
			cmd = int(cmd)
			if (cmd == 0):
				print ('-'*28 + '指令' + '-'*28)
				player.save_game()
				cmd_accepted = 1
				game_end = 1

			elif (cmd > 0 and cmd <= player.bank):
				print ('-'*28 + '指令' + '-'*28)
				respond = player.set_off(cmd)
				cmd_accepted = 1
				if respond == -1:
					print('\n\n请等' + char_name + '回来之后再输入指令。。。')
			elif (cmd == -2):
				print ('-'*28 + '指令' + '-'*28)
				print ('正在刷新。。')
				cmd_accepted = 1
			else:
				print ("请输入正确指令。")
				print_menu(player)



