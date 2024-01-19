#from flask import Flask, redirect, url_for, render_template, request, make_response
#from flask import session
from flask_session import Session
from flask_login import LoginManager

from flask import Flask, render_template, request 
from flask_wtf import FlaskForm 
from wtforms import StringField, PasswordField, BooleanField 
from wtforms import DecimalField, RadioField, SelectField, TextAreaField, FileField 
from wtforms.validators import InputRequired 
from werkzeug.security import generate_password_hash 

#------------------------------------------------------------------------------
app = Flask(__name__)
app.config['SECRET_KEY'] = 'Rotem Eadiation Detection'
app.config['SESSION_TYPE'] = 'filesystem'
Session(app)
gstrApp = "Rotem Radiation Tests and Bugs"
login_manager = LoginManager()
login_manager.init_app(app)
#------------------------------------------------------------------------------
@app.route('/')
def index():
	return render_template ('index.html', name = gstrApp)
#------------------------------------------------------------------------------
@app.route('/tests')
def tests_main():
	return render_template ('tests.html', name = gstrApp)
#------------------------------------------------------------------------------
@app.route('/bugs')
def bugs_main():
	return render_template ('bugs.html', name = gstrApp)
#------------------------------------------------------------------------------
@app.route('/admin')
def admin_main():
	return render_template ('admin.html', name = gstrApp)
#------------------------------------------------------------------------------
@app.route('/about')
def about_handler():
	return render_template ('about.html', name = gstrApp)
#------------------------------------------------------------------------------
from login import LoginForm
@app.route('/navbar_login', methods=['post', 'get'])
def login_main ():
	form = LoginForm()
	if form.validate_on_submit(): 
		name = form.username.data
		password = form.password.data
		print (f'Name: {name}')
		print (f'Password: {password}')

	return render_template ('login.html', name = gstrApp, form=form)
#------------------------------------------------------------------------------
@app.route('/login_handler', methods=['post', 'get'])
def login_response ():
	print (f'method: {request.method}')
	return render_template ('login.html', name = gstrApp)
#------------------------------------------------------------------------------
class User ():
	is_authenticated = False
	is_active = False
	is_anonymous = False
	def get_id (self):
		return 17
#------------------------------------------------------------------------------
@login_manager.user_loader
def load_user(user_id):
	return User.get(user_id)
#------------------------------------------------------------------------------
if __name__ == '__main__':
	app.run(debug=True, host='0.0.0.0', port=5010)
#------------------------------------------------------------------------------

