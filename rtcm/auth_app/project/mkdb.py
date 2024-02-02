import sqlite3
from sqlite3 import Error

def create_connection(db_file):
    """ create a database connection to the SQLite database
        specified by db_file
    :param db_file: database file
    :return: Connection object or None
    """
    conn = None
    try:
        conn = sqlite3.connect(db_file)
        return conn
    except Error as e:
        print(e)

    return conn


def create_table(conn, create_table_sql):
    """ create a table from the create_table_sql statement
    :param conn: Connection object
    :param create_table_sql: a CREATE TABLE statement
    :return:
    """
    try:
        c = conn.cursor()
        c.execute(create_table_sql)
    except Error as e:
        print(e)

txtCreate = """CREATE TABLE IF NOT EXISTS user (
	id integer PRIMARY KEY,
	name text NOT NULL,
	email text,
	password text
);"""

#conn = create_connection('db.sqlite')
#if conn is not None:
	#create_table(conn, txtCreate)
	#print('Created')
#else:
	#print('not Created')


#create_connection('db.sqlite')
