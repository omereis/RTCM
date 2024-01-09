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
def user(name=None):
#def useri(name):
	#return render_template ('index.html')
	#if not 'name' in vars():
		#name='o'
	#print(f'name={name}')
	#return render_template ('user.html')
	return render_template ('user.html', user_name=name)
	#return (f'<h3>Hello {name}</h3>')
	
#------------------------------------------------------------------------------
if __name__ == '__main__':
	app.run(debug=True, host='0.0.0.0', port=5010)


