from . import db, db_name
import os
import json
from .models import TUser

#------------------------------------------------------------------------------
class TUsersDB():
#------------------------------------------------------------------------------
	def __init__(self):
		self.db_name = None
#------------------------------------------------------------------------------
	def query (self, id=None, name=None, email=None, password=None):
		user = None
		user = TUser(id=id, name=name, email=email, password=password)
		aUsers = self.LoadAll()
		if aUsers != None:
			user = User(id=id, email=email, password=password, name=name)
		return user
#------------------------------------------------------------------------------
	def insert_as_new(self, user):
		aUsers = LoadAll()
		if aUsers == None:
			aUsers = []
			id = 0
		else:
			id = get_max_id(aUsers)
		user.id = id + 1
		aUsers.append(user)
		save_all(aUsers)
#------------------------------------------------------------------------------
	def get_max_id(self, aUsers):
		id = 0
		try:
			for u in aUsers:
				i = max (i, u.id)
		except Exception as e:
			print(f'runtime error in get_max_id: {e}')
		return id
#------------------------------------------------------------------------------
	def save_all(self, aUsers):
		a = 8
#------------------------------------------------------------------------------
	def init_db(self):
		if not os.path.exists(db_name):
			with open(db_name, 'w') as f:
				pass
#------------------------------------------------------------------------------
	def LoadAll(self):
		aUsers = None
		if os.path.exists(db_name):
			try:
				with open(db_name) as f:
					aUsers = json.load(f)
					print(aUsers)
			except Exception as e:
				print ('DB Error')
		return aUsers

