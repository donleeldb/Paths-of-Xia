from datetime import datetime
from datetime import timedelta


def gt(dt_str):
	dt, _, us= dt_str.partition(".")
	dt= datetime.strptime(dt, "%Y-%m-%dT%H:%M:%S")
	us= int(us.rstrip("Z"), 10)
	return dt + timedelta(microseconds=us)
