import random

class Leaf(dict):

    def __init__(self, iterable = None):
        super(Leaf, self).__init__()
        self.types = 0
        self.tokens = 0
        if (iterable):
            self.update(iterable)

    def update(self, item):
        if (item in self):
            self[item] += 1
            self.tokens += 1
        else:
            self[item] = 1
            self.tokens += 1
            self.types += 1

    def count(self, item):
        if (item in self):
            return self[item]
        return 0

    def get_random_word(self):
        rand_int = random.randint(0, self.tokens - 1)
        ind = 0
        keys = self.keys()
        for key in keys:
            ind += self[key]
            if ind > rand_int:
                return key

class MarkovSerice:

    def __get_model(self, data):
        model = dict()
        for i in range(0, len(data) - 1):
            if data[i] in model:
                model[data[i]].update(data[i + 1])
            else:
                model[data[i]] = Leaf(data[i + 1])
        return model

    def __get_start(self, model):
        return model["."].get_random_word();

    def __get_sentence(self, model, max_length):
        curr = self.__get_start(model)
        res = str(curr)
        next = model[curr].get_random_word()
        while len(res + " " + next) < max_length:
            res += " " + next
            curr = next
            next = model[curr].get_random_word()
        return res.replace(" .", ".")

    def __validate_data(self, data):
        val = str(data).strip()
        if val[len(val) - 1] != ".":
            val += "."
        val = val.replace(".", " .")
        val = ". " + val
        return val.split(" ")

    def generate_text(self, data, max_length=70):
        valid_data = self.__validate_data(data)
        model = self.__get_model(valid_data)
        sentence = self.__get_sentence(model, max_length)
        return sentence



#text = "Hello guys from world. This very interesting it is very not interesting bich. Vot tak vot hello from"
#print(validate_data(text))
#model = get_model(validate_data(text))
#print(model)
#print(get_sentence(model))

        