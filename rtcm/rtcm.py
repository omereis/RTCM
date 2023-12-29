from flask import Flask, redirect, url_for, render_template, request
app = Flask(__name__)
#------------------------------------------------------------------------------
@app.route('/hello/<name>')
def hello_name (name):
	return f'hello {name}'
#------------------------------------------------------------------------------
@app.route('/log')
def hello_world():
	return render_template ('login.html')
	#return 'Hello World'
#------------------------------------------------------------------------------
@app.route('/hello_html')
def hello_html():
	return '<html><body><h1>Hello World</h1></body></html>'
#------------------------------------------------------------------------------
@app.route('/result')
def result():
   dict = {'phy':50,'che':60,'maths':70}
   return render_template('result.html', result = dict)
#------------------------------------------------------------------------------
@app.route('/hello/<int:score>')
def hello_pf_name(score):
   return render_template('pas_fail.html', marks = score)
#------------------------------------------------------------------------------
@app.route('/')
def index():
	return render_template ('index.html')
	#return '<html><body><h1>Hello World</h1></body></html>'
#------------------------------------------------------------------------------
@app.route('/success/<name>')
def success(name):
   return 'welcome %s' % name
#------------------------------------------------------------------------------
@app.route('/login',methods = ['POST', 'GET'])
def login():
	if request.method == 'POST':
		user = request.form['nm']
	else:
		user = request.args.get('nm')
	return redirect(url_for('success',name = user))
      #return redirect(url_for('success',name = user))
#------------------------------------------------------------------------------
@app.route('/blog/')
def hello_blog():
	return 'Welcome to the BLOGS'
#------------------------------------------------------------------------------
@app.route('/blog/<int:postID>')
def show_blog(postID):
	return f'Blog Number {postID}'
#------------------------------------------------------------------------------
@app.route('/blog/rev/<float:revNo>')
def revision(revNo):
	return f'Revision Number {revNo}'
#------------------------------------------------------------------------------
#@app.route('/users/admin/')
@app.route('/users/admin/<name>')
def hello_admin(name=None):
	strHello = 'Hello Admin'
	if name is not None:
		strHello += f' {name}'
	return strHello
#------------------------------------------------------------------------------
@app.route('/guest/<guest>')
def hello_guest(guest):
   return 'Hello %s as Guest' % guest
#------------------------------------------------------------------------------
@app.route('/users/<name>')
def hello_user(name=None):
	if name =='admin':
		return redirect(url_for('hello_admin', name = name))
	else:
		return redirect(url_for('hello_guest',guest = name))
#------------------------------------------------------------------------------
if __name__ == '__main__':
	app.run(debug=True, host='0.0.0.0', port=5010)
