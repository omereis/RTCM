from flask import Flask, redirect, url_for, render_template, request, make_response
from flask import session
from flask_session import Session
#------------------------------------------------------------------------------
app = Flask(__name__)
app.config['SECRET_KEY'] = 'RRD' #Rotem Eadiation Detection
app.config['SESSION_TYPE'] = 'filesystem'
Session(app)
#------------------------------------------------------------------------------
@app.route('/')
def index():
	return render_template ('index.html')
#------------------------------------------------------------------------------
if __name__ == '__main__':
	app.run(debug=True, host='0.0.0.0', port=5010)
#------------------------------------------------------------------------------

