from markov import *
from flask import Flask, request, jsonify, abort
app = Flask(__name__)

@app.route('/')
def hello():
    return 'hi'

@app.route('/api/markov', methods=['POST'])
def markov():
    req_data = request.get_json(force=True)
    if 'model_data' not in req_data:
        abort(400, 'Field {model_data} not found')
    model_data = req_data['model_data']
    if 'max_length' in req_data:
        return jsonify(generate_text(model_data, int(req_data['max_length'])))
    return jsonify(generate_text(model_data))

