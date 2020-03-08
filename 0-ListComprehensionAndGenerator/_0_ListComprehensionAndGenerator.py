from time import sleep

# Print thier upper case whoes length is less than 3.
str_li = ['abc', 'cd', 'xy']
print([s.upper() for s in str_li if len(s) < 3])

# Find (x, y) where x is an even number between 0-5 and y is an ancestor list consisting of odd numbers between 0-5
print([(x, y) for x in range(6) if x % 2 == 0 for y in range(6) if y % 2 == 1])

# Find a list of 3,6,9 in M, M ​​= [[1,2,3], [4,5,6], [7,8,9]]
M = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
print([m[2] for m in M])

# Dictionary comprehension
D = {(k, 2 * k) for k in range(6)}
# Swap its key and value
D_ = {(v, k) for (k, v) in D}
print(D, D_)

# A method that returns a generator
def WhatToEatTonight():
    sleep(1)
    yield "noddles"
    sleep(1)
    yield "dumplings"
    sleep(1)
    yield "fast food"
    sleep(1)
    yield "rice"
    sleep(1)
    yield "cake"

for f in WhatToEatTonight():
    print(f)

# A method returns generator with arg(s)
def fib(max):
    n, a, b = 0, 0, 1
    while n < max:
        yield b
        a, b = b, a + b
        n += 1

for n in fib(15):
    print(n)


# Producer and consumer
def consumer(name):
    print(name, " is ready to consume.")
    while True:
        p = yield
        print("%s comsumes %d" % (name, p))

def producer():
    c = consumer("A")
    next(c)
    for p in range(1, 3):
        print("%s is made." % p)
        c.send(p)

producer()
