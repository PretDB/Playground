#include <cassert>
#include <iostream>
#include <thread>
#include <vector>
#include <algorithm>
#include <list>
#include <cstdio>

int something = 0;
volatile int flag = false;

void thread1()
{
    something = 1;
    flag = true;
}

void thread2()
{
    if (flag == true)
    {
        assert(something == 1);


    }
}

class Accumulator
{
public:
    int value = 0;
    Accumulator(int v) :value(v)
    {
    }

    void operator()(int v)
    {
        value += v;

        return;
    }
};

int main(int argc, char** argv)
{
    std::list<int> data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    Accumulator acc(0);


    std::cout << (std::for_each(data.cbegin(), data.cend(), Accumulator(0))).value << std::endl;

    union V {
        struct X {
            unsigned char s1 : 2;
            unsigned char s2 : 3;
            unsigned char s3 : 3;
        }x;
        unsigned char c;
    }v;
    v.x = { 2, 3, 4 };
    printf("%d\t0x%X\t0x%X\n", sizeof(v), &(v.x), &(v.c));
    printf("%d\t%d\t%d\t%d\n", v.x.s1, v.x.s2, v.x.s3, v.c);
    v.c = 100;
    printf("%d\t%d\t%d\t%d\n", v.x.s1, v.x.s2, v.x.s3, v.c);
}