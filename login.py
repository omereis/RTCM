# Source: https://www.geeksforgeeks.org/flask-wtf-explained-how-to-use-it/
from flask import Flask, render_template, request 
from flask_wtf import FlaskForm 
from wtforms import StringField, PasswordField, BooleanField 
from wtforms import DecimalField, RadioField, SelectField, TextAreaField, FileField 
from wtforms.validators import InputRequired 
from werkzeug.security import generate_password_hash 

class LoginForm(FlaskForm):
	username = StringField('Name', validators=[InputRequired()]) 
	password = PasswordField('Password', validators=[InputRequired()]) 
