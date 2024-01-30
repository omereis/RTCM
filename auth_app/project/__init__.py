from flask import Flask
from flask_sqlalchemy import SQLAlchemy
import os

# init SQLAlchemy so we can use it later in our models
db = SQLAlchemy()
db_name = os.path.join(os.getcwd(),'users.json')

def create_app():
    app = Flask(__name__)

    app.config['SECRET_KEY'] = 'secret-key-goes-here'
    app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///db_users.sqlite'

    db.init_app(app)

    # blueprint for auth routes in our app
    from .auth import auth as auth_blueprint
    app.register_blueprint(auth_blueprint)

    # blueprint for non-auth parts of app
    from .main import main as main_blueprint
    app.register_blueprint(main_blueprint)

    return app

