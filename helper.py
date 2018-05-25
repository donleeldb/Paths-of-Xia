from datetime import datetime
from datetime import timedelta

activities = [	'行侠仗义、并得到百姓的报酬',
				'劫富济贫、也为自己留了']

def gt(dt_str):
	dt, _, us= dt_str.partition(".")
	dt= datetime.strptime(dt, "%Y-%m-%dT%H:%M:%S")
	us= int(us.rstrip("Z"), 10)
	return dt + timedelta(microseconds=us)
