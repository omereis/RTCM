from flask import Flask
from flask_sqlalchemy import SQLAlchemy
from flask_wtf import FlaskForm 
from wtforms import StringField, PasswordField, BooleanField 
from wtforms import DecimalField, RadioField, SelectField, TextAreaField, FileField 
from wtforms.validators import InputRequired 
from werkzeug.security import generate_password_hash 

import datetime

db = SQLAlchemy()
g_strSqliteDB = 'sqlite:///db_users.sqlite'
app = Flask(__name__)
app.config['SECRET_KEY'] = 'secret-key-goes-here'
app.config['SQLALCHEMY_DATABASE_URI'] = g_strSqliteDB# 'sqlite:///db_users.sqlite'
db.init_app(app)

#------------------------------------------------------------------------------
class Users(db.Model):
	id = db.Column (db.Integer, primary_key=True)
	name =  db.Column (db.String(100), nullable=False)
	password =  db.Column (db.String(100), nullable=False)
	email =  db.Column (db.String(100), nullable=False, unique=True)
	date_of_birth =  db.Column (db.DateTime, default=datetime.datetime.now())

	def __repr__(self):
		s = f'<name {self.name}>'
		return (s)
#------------------------------------------------------------------------------
class UserForm (FlaskForm):
	name = StringField('Name', validators=[InputRequired()]) 
	password = PasswordField('Password', validators=[InputRequired()]) 
	email = StringField('Email', validators=[InputRequired()]) 
#------------------------------------------------------------------------------
app.route('/')
def index():
	print('index')
	return render_template ('index.html')

#------------------------------------------------------------------------------
app.route('/user', methods=['GET', 'POST'])
def add_user():
	print('add_user')
	return render_template ('add_user.html')

#------------------------------------------------------------------------------
def create_app():
    app = Flask(__name__)

    app.config['SECRET_KEY'] = 'secret-key-goes-here'
    app.config['SQLALCHEMY_DATABASE_URI'] = g_strSqliteDB# 'sqlite:///db_users.sqlite'

    db.init_app(app)

    # blueprint for auth routes in our app
    from .auth import auth as auth_blueprint
    app.register_blueprint(auth_blueprint)

    # blueprint for non-auth parts of app
    from .main import main as main_blueprint
    app.register_blueprint(main_blueprint)

    return app
#------------------------------------------------------------------------------

#if __name__ == '__main__':
	#app.run(debug=True, host='0.0.0.0', port=5010)

