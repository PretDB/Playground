from time import sleep
def consumer(name):
    r = ''
    print(name, " is ready to consume.")
    while True:
        p = yield r
        if not p:
            return
        else:
            print("[CONSUMER] Consuming: %s" % p)
            sleep(1)
            r = "200 OK"

def producer(c):
    next(c)

    for p in range(1, 5):
        print("[PRODUCER] Producing %s" % p)
        r = c.send(p)
        print("[PRODUCER] Consumer return: %s" % r)
    c.close()

c = consumer("A")
producer(c)
