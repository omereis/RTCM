from flask import Blueprint, render_template, redirect, url_for, request
from werkzeug.security import generate_password_hash, check_password_hash
from .models import User
from . import db

auth = Blueprint('auth', __name__)

#------------------------------------------------------------------------------
@auth.route('/login')
def login():
    return render_template('login.html')
#------------------------------------------------------------------------------
@auth.route('/signup')
def signup():
    return render_template('signup.html')
#------------------------------------------------------------------------------
@auth.route('/signup', methods=['POST'])
def signup_post():
    # code to validate and add user to database goes here
	email = request.form.get('email')
	name = request.form.get('name')
	password = request.form.get('password')

	#print(f'email: {email}')
	#print(f'name: {name}')
	#print(f'password: {password}')
	print('\n\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++')
	print(f'dir(db.engine.url.database):\n{dir(db.engine.url.database)}')
	print(f'db.engine.url.database): "{str(db.engine.url.database)}"')
	print('++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++')
	print(f'dir(db.engine):\n{dir(db.engine)}')
	print('++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++')
	print(f'dir(User):\n{dir(User)}')
	print('--------------------------------------------------------------')
	print(f'dir(User.metadata):\n{dir(User.metadata)}')
	print(f'type(User.metadata.tables):\n{type(User.metadata.tables)}')
	print(f'str(User.metadata.tables):\n{str(User.metadata.tables)}')
	print('+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n\n')
	try:
		#user = User.query.filter_by(email=email).first() # if this returns a user, then the email already exists in database
		user = User.query.filter_by(email=email).first() # if this returns a user, then the email already exists in database
	except Exception as e:
		print('\n\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++')
		print('query runtime error')
		print(f'{e}')

	try:
		if user: # if a user is found, we want to redirect back to signup page so user can try again
			return redirect(url_for('auth.signup'))
		print (f'user {name} not found')

    # create a new user with the form data. Hash the password so the plaintext version isn't saved.
		new_user = User(email=email, name=name)#, password=generate_password_hash(password, method='sha256'))
	except Exception as e:
		print('\n\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++')
		print('runtime error')
		print(f'{e}')
		print('+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n\n')

    # add the new user to the database
	db.session.add(new_user)
	db.session.commit()

	return redirect(url_for('auth.login'))
#------------------------------------------------------------------------------
@auth.route('/logout')
def logout():
    return 'Logout'

