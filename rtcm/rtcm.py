from flask import Flask, redirect, url_for, render_template, request, make_response
app = Flask(__name__)
#------------------------------------------------------------------------------
@app.route('/cookies')
def	cookies():
	return render_template("cookies_set.html")
#------------------------------------------------------------------------------
@app.route('/setcookie', methods = ['POST', 'GET'])
def setcookie():
	if request.method == 'POST':
		user = request.form['nm']
		resp = make_response(render_template('cookies_read.html'))
		resp.set_cookie('userID', user)
		return resp
	else:
		return 'GET'
#------------------------------------------------------------------------------
@app.route('/getcookie')
def getcookie():
   name = request.cookies.get('userID')
   return '<h1>welcome '+name+'</h1>'
#------------------------------------------------------------------------------
@app.route('/student_result_form',methods = ['POST', 'GET'])
def	student_form():
	return render_template("student_result.html")
#------------------------------------------------------------------------------
@app.route('/student_result',methods = ['POST', 'GET'])
def student_result():
	if request.method == 'POST':
		result = request.form
		return render_template("student_report.html",result = result)
	else:
		eresult = None
		return render_template("student_result.html",result = result)
		#return 'GET'
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
@app.route('/hello_js')
def hello_js():
	return render_template ('hello_js.html')
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

