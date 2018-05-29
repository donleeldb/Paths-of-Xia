

class World:
	def __init__(self):
		self.world_name = '中国'
		self.world_map = Map()

class Map:
	def __init__(self):
		self.sites = generate_all_sites()


class Site:
	def __init__(self, name, paths, npcs, wuxue=None):
		self.site_name = name
		self.npcs = npcs
		# self.wuxue = wuxue
		self.paths = paths

	# def add_paths ( paths ):
	# 	self.paths = paths

	# def add_npcs ( npcs ):
	# 	self.npcs = npcs

	# def add_wuxue ( wuxue ):
	# 	self.wuxue = wuxue

class Npc:
	def __init__(self, name, wuxue ): 
		self.name = name
		self.wuxue = wuxue

'''
def generate_all_sites():

	sites = {}
	name = '牛家村'
	npcs = []
	paths = {}
	paths['牛家村-东'] = 5
	paths['牛家村-南'] = 5
	paths['牛家村-西'] = 5
	paths['牛家村-北'] = 5
	sites['牛家村'] = Site(name, paths, npcs)

	name = '牛家村-东'
	npcs = []
	paths = {}
	paths['桃花岛'] = 50
	paths['玉盘山岛'] = 50
	paths['燕子坞'] = 30
	sites['牛家村-东'] = Site(name, paths, npcs)

	name = '牛家村-南'
	npcs = []
	paths = {}
	paths['铸剑古'] = 30
	sites['牛家村-南'] = Site(name, paths, npcs)

	name = '牛家村-西'
	npcs = []
	paths = {}
	paths['梅庄'] = 5
	paths['归云庄'] = 45
	paths['铸剑古'] = 40
	paths['牛家村-北'] = 5
	sites['牛家村-西'] = Site(name, paths, npcs)

	name = '牛家村-北'
	npcs = []
	paths = {}
	paths['归云庄'] = 20
	paths['燕子坞'] = 22
	paths['长乐帮'] = 28
	paths['蝴蝶谷'] = 40
	sites['牛家村-北'] = Site(name, paths, npcs)

	name = '长乐帮'
	npcs = []
	paths = {}
	paths['蝴蝶谷'] = 25
	sites['长乐帮'] = Site(name, paths, npcs)

	name = '铸剑古'
	npcs = []
	paths = {}
	paths['南少林'] = 55
	paths['福威镖局'] = 40
	sites['铸剑古'] = Site(name, paths, npcs)

	name = '蝴蝶谷'
	npcs = []
	paths = {}
	paths['泰山派'] = 75
	paths['五霸岗'] = 65
	paths['大胜关'] = 60
	sites['蝴蝶谷'] = Site(name, paths, npcs)

	name = '泰山派'
	npcs = []
	paths = {}
	sites['泰山派'] = Site(name, paths, npcs)

	name = '南少林'
	npcs = []
	paths = {}
	sites['南少林'] = Site(name, paths, npcs)

	name = '福威镖局'
	npcs = []
	paths = {}
	sites['福威镖局'] = Site(name, paths, npcs)

	name = '泰山派'
	npcs = []
	paths = {}
	sites['泰山派'] = Site(name, paths, npcs)

	name = '五霸岗'
	npcs = []
	paths = {}
	sites['五霸岗'] = Site(name, paths, npcs)

	name = '大胜关'
	npcs = []
	paths = {}
	sites['大胜关'] = Site(name, paths, npcs)

	name = '燕子坞'
	npcs = []
	paths = {}
	sites['燕子坞'] = Site(name, paths, npcs)

	name = '归云庄'
	npcs = []
	paths = {}
	sites['归云庄'] = Site(name, paths, npcs)

	name = '玉盘山岛'
	npcs = []
	paths = {}
	sites['玉盘山岛'] = Site(name, paths, npcs)

	name = '桃花岛'
	npcs = []
	paths = {}
	sites['桃花岛'] = Site(name, paths, npcs)

	name = '梅庄'
	npcs = []
	paths = {}
	sites['梅庄'] = Site(name, paths, npcs)

	return sites
'''