from World import Site
from World import Npc
genearl_acts = [	'行侠仗义、并得到百姓的报酬',
					'劫富济贫、也为自己留了']

world_npcs = [ 	[ 	'洪七公', 2, [	'亢龙有悔', '飞龙在天', '见龙在田', '鸿渐于陆', '潜龙勿用', '突如其来', 
								'利涉大川', '震惊百里', '或跃在渊', '双龙取水', '鱼跃于渊', '时乘六龙', 
								'密云不雨', '损则有孚', '龙战于野', '履霜冰至', '鱼跃于渊', '时乘六龙'] ],
			[ 	'黄药师', 2, [ 	'落英神剑', '弹指神通', '落英神剑掌', '玉箫剑法', '旋风扫叶腿'] ],

		]
# Generate People


# Generate Map
world_sites = {}
name = '牛家村'
npcs = []
paths = {}
paths['牛家村-东'] = 5
paths['牛家村-南'] = 5
paths['牛家村-西'] = 5
paths['牛家村-北'] = 5
world_sites['牛家村'] = Site(name, paths, npcs)

name = '牛家村-东'
npcs = []
paths = {}
paths['桃花岛'] = 50
paths['玉盘山岛'] = 50
paths['燕子坞'] = 30
world_sites['牛家村-东'] = Site(name, paths, npcs)

name = '牛家村-南'
npcs = []
paths = {}
paths['铸剑古'] = 30
world_sites['牛家村-南'] = Site(name, paths, npcs)

name = '牛家村-西'
npcs = []
paths = {}
paths['梅庄'] = 5
paths['归云庄'] = 45
paths['铸剑古'] = 40
paths['牛家村-北'] = 5
world_sites['牛家村-西'] = Site(name, paths, npcs)

name = '牛家村-北'
npcs = []
paths = {}
paths['归云庄'] = 20
paths['燕子坞'] = 22
paths['长乐帮'] = 28
paths['蝴蝶谷'] = 40
world_sites['牛家村-北'] = Site(name, paths, npcs)

name = '长乐帮'
npcs = []
paths = {}
paths['蝴蝶谷'] = 25
world_sites['长乐帮'] = Site(name, paths, npcs)

name = '铸剑古'
npcs = []
paths = {}
paths['南少林'] = 55
paths['福威镖局'] = 40
world_sites['铸剑古'] = Site(name, paths, npcs)

name = '蝴蝶谷'
npcs = []
paths = {}
paths['泰山派'] = 75
paths['五霸岗'] = 65
paths['大胜关'] = 60
world_sites['蝴蝶谷'] = Site(name, paths, npcs)

name = '泰山派'
npcs = []
paths = {}
world_sites['泰山派'] = Site(name, paths, npcs)

name = '南少林'
npcs = []
paths = {}
world_sites['南少林'] = Site(name, paths, npcs)

name = '福威镖局'
npcs = []
paths = {}
world_sites['福威镖局'] = Site(name, paths, npcs)

name = '泰山派'
npcs = []
paths = {}
world_sites['泰山派'] = Site(name, paths, npcs)

name = '五霸岗'
npcs = []
paths = {}
world_sites['五霸岗'] = Site(name, paths, npcs)

name = '大胜关'
npcs = []
paths = {}
world_sites['大胜关'] = Site(name, paths, npcs)

name = '燕子坞'
npcs = []
paths = {}
world_sites['燕子坞'] = Site(name, paths, npcs)

name = '归云庄'
npcs = []
paths = {}
world_sites['归云庄'] = Site(name, paths, npcs)

name = '玉盘山岛'
npcs = []
paths = {}
world_sites['玉盘山岛'] = Site(name, paths, npcs)

name = '桃花岛'
npcs = []
paths = {}
world_sites['桃花岛'] = Site(name, paths, npcs)

name = '梅庄'
npcs = []
paths = {}
world_sites['梅庄'] = Site(name, paths, npcs)
