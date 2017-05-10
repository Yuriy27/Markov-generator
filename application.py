from markov import MarkovSerice
from flask import Flask, request, jsonify, abort
import os

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
    print(resp)
    re = dict()
    re['text'] = resp
    return jsonify(re)

@app.route('/api/markov/upload', methods=['POST'])
def upload():
    if 'file_data' not in request.files:
        abort(400, '{file_data} not found')
    file = request.files['file_data']
    path = '/home/yuriy27/dev/python/markov/uploads'
    f_name = file.filename
    file.save(os.path.join(path, f_name))
    file.close()
    file = open(path + '/' + f_name, mode='r')
    resp = None
    if 'max_length' in request.form:
        resp = markov_service.generate_text(file.read(), int(request.form['max_length']))
    else:
        resp = markov_service.generate_text(file.read())
    file.close()
    return jsonify(resp)



