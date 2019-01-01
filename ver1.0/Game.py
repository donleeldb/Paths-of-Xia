from Player import Player

class Game:
	def __init__(self, saved_data=None):

		if os.path.isfile(saved_data):

			self.load_from_data(saved_data)
			
		else: 
			self.new_game()
			self.is_away = 0
			self.is_home = 0
			self.at_door_step = 0


	def new_game():
		return 1

	def load_from_data(saved_data):
		return 0