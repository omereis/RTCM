from . import db, db_name
import os
import json

#------------------------------------------------------------------------------
class TUser():
#class User(db.Model):
#------------------------------------------------------------------------------
	def __init__ (self, id=0, name='', email='', password=''):
		self.id = id#id = db.Column(db.Integer, primary_key=True) # primary keys are required by SQLAlchemy
		self.email = email#db.Column(db.String(100), unique=True)
		self.password = password#db.Column(db.String(100))
		self.name = name#db.Column(db.String(1000))
#------------------------------------------------------------------------------
	#def as_json(self):
	def __str__(self):
		dct = {}
		dct['id'] = self.id
		dct['email'] = self.email
		dct['password'] = self.password
		dct['name'] = self.name
		return str(dct)

#------------------------------------------------------------------------------
	#id = db.Column(db.Integer, primary_key=True) # primary keys are required by SQLAlchemy
	#email = db.Column(db.String(100), unique=True)
	#password = db.Column(db.String(100))
	#name = db.Column(db.String(1000))
#------------------------------------------------------------------------------
class Foo():
	def __init__(self):
		self.bar=7

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
	def LoadAll(self):
		aUsers = None
		if os.path.exists(db_name):
			with open(db_name) as f:
				aUsers = json.load(f)
				print(aUsers)
		return aUsers

