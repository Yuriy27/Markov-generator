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

def get_model(data):
    model = dict()
    for i in range(0, len(data) - 1):
        if data[i] in model:
            model[data[i]].update(data[i + 1])
        else:
            model[data[i]] = Leaf(data[i + 1])
    return model


def get_start(model):
    return model["."].get_random_word();

def get_sentence(model, length):
    curr = get_start(model)
    res = [curr]
    for i in range(0, length - 1):
        curr = model[curr].get_random_word()
        res.append(curr)
    return " ".join(res)


model = get_model([".", "one",".", "two", "three", "two", "one", "two", "one"])
print(model)
print(get_sentence(model, 5))

        