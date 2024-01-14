from flask import Flask, render_template

app = Flask(__name__)

#------------------------------------------------------------------------------
@app.route('/')
def index():
	name='Addel'
	stuff = 'This <b>HTML</b> code'
	toppings = ['pepperoni','cheese','mushrooms', 17]
	return render_template ('hello.html', first_name=name, stuff=stuff, toppings=toppings)
	#return ('<h3>Hello</h3>')
#------------------------------------------------------------------------------
@app.route('/user/<name>')
@app.route('/user/')
def user_handler(name=None):
	return render_template ('user.html', user_name=name)
#------------------------------------------------------------------------------
@app.errorhandler(404)
def err_page_not_found(e):
	return render_template ('404.html'), 404
#------------------------------------------------------------------------------
@app.errorhandler(500)
def err_server_error(e):
	return render_template ('500.html'), 500
#------------------------------------------------------------------------------
if __name__ == '__main__':
	app.run(debug=True, host='0.0.0.0', port=5010)


