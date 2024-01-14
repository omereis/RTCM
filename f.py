from flask import Flask, session, redirect
from flask_session import Session

app = Flask(__name__)
app.config['SECRET_KEY'] = 'your_secret_key_here'
app.config['SESSION_TYPE'] = 'filesystem'


Session(app)


@app.route('/')
def index():
	print(f'session type {type(session)}')
	session['username'] = 'John' # Storing 'John' as the value for the key 'username' in the session
	print('\nusername set')
	return 'Pythongeeks Session data stored!'


@app.route('/profile')
def profile():
   username = session.get('username') # Retrieving the value associated with the key 'username' from the session
   if username:
       return f'Welcome, {username}!'
   else:
       return 'No user data found in session.'


@app.route('/logout')
def logout():
   session.clear() # Clearing all data from the session
   return 'Logged out successfully!'


if __name__ == '__main__':
	print(f'session type {type(session)}')
	app.run(debug=True, host='0.0.0.0', port=5010)
	#app.run()

