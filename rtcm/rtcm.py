from flask import Flask, redirect, url_for, render_template, request, make_response
from flask import session
from flask_session import Session
#------------------------------------------------------------------------------
app = Flask(__name__)
app.config['SECRET_KEY'] = 'RRD' #Rotem Eadiation Detection
app.config['SESSION_TYPE'] = 'filesystem'
Session(app)
gstrApp = "Rotem Radiation Tests and Bugs"
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
if __name__ == '__main__':
	app.run(debug=True, host='0.0.0.0', port=5010)
#------------------------------------------------------------------------------

