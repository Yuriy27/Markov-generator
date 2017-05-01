from markov import MarkovSerice
from flask import Flask, request, jsonify, abort

app = Flask(__name__)

markov_service = MarkovSerice()

@app.route('/')
def hello():
    return 'hi'

@app.route('/api/markov', methods=['POST'])
def markov():
    req_data = request.get_json(force=True)
    if 'model_data' not in req_data:
        abort(400, 'Field {model_data} not found')
    model_data = req_data['model_data']
    resp = None
    if 'max_length' in req_data:
        resp = markov_service.generate_text(model_data, int(req_data['max_length']))
    else:
        resp = markov_service.generate_text(model_data)
    return jsonify(resp)

