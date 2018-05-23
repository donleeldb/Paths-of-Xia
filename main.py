import os
import sys

from Player import Player


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
		
		print('='*60)

		if (player.at_door_step): 
			exit()

		elif (player.is_away):
			print (char_name + "出门游历去了。请耐心等待。。。")
 
		elif (player.is_home):
			print (char_name + "正在家中修炼" + player.choose_one_wuxue() + "。") 

		print (char_name + "的积蓄有" + str(player.bank) + "碎银。" + "如果你准备好了，可以为" + char_name + "准备下次出门的盘缠。")
		
		cmd_accepted = 0

		while ( not cmd_accepted ):
			cmd = input(char_name + "下次出门将会带多少碎银？ （ 输入 0 可以保存并退出游戏）")
			cmd = int(cmd)
			if (cmd == 0):
				player.save_game()
				cmd_accepted = 1
				game_end = 1

			elif (cmd > 0 and cmd <= player.bank):
				player.set_off(cmd)
				cmd_accepted = 1
			else:
				print ("请输入正确指令。")



