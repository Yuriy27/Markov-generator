from markov import *
from flask import Flask
from flask import request
app = Flask(__name__)

@app.route('/')
def hello():
    return 'hi'

@app.route('/markov', methods=['POST'])
def markov():
     pass
