from time import sleep, time

# Extend a method directly.
def foo():
    # ---- extended content ----
    start = time()
    # ---- extended content ----

    print("Hello")
    sleep(1)
    print("World")

    # ---- extended content ----
    print("Total time: %f" % (time() - start))
    # ---- extended content ----

foo()

def ext(func_to_decorate):
    def wrapper():
        start = time()
        func_to_decorate()
        print("Total time: %f" % (time() - start))
        
    return wrapper

@ext
def core_code():
    print("This pile of code is not allowed to change directly.")
    sleep(1)
    print("Hello world")

core_code()

def ext_with_args(func_to_decorate):
    def wrapper(*args, **kwargs):
        start = time()
        func_to_decorate(*args, **kwargs)
        print("Total: %f" % (time() - start))

    return wrapper

@ext_with_args
def core_code_with_args1(arg1):
    print(arg1)
    print("Hello world")


@ext_with_args
def core_code_with_args2(arg1, arg2):
    print(arg1, arg2)
    print("Hello world")

@ext_with_args
def core_code_with_args3(arg1, arg2, arg3):
    print(arg1, arg2, arg3)
    print("Hello world")

core_code_with_args1(1)
core_code_with_args2(1, 2)
core_code_with_args3(1, 2, 3)

print("Work with more decorators...")

def deco1(func):
    print("In deco1")
    def one():
        start = time()
        print("Deco1 start: %f" % start)
        func()
        print("Deco1 total: %f" % (time() - start))

    print("end of deco1")
    return one

def deco2(func):
    print("In deco2")
    def two():
        start = time()
        print("Deco2 start: %f" % start)
        func()
        print("Deco2 total: %f" % (time() - start))

    print("end of deco2")
    return two

@deco1
@deco2
def core_code_with_many_decorators():
    print("Hello")
    sleep(1)
    print("World")

core_code_with_many_decorators()
# deco2
#   do some thing in deco2
#   deco1
#     do some thing in deco1
#     excute one()
#       excute two()
#         func
#       end of tow()
#     end of one()
#   end of deco1
# end of deco2