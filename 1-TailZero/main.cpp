#include <iostream>


int count_2 = 0;
int count_5 = 0;
int count_0 = 0;

void count(long long n);

int main()
{
    int input = 0;
    int test = 1;

    std::cin >> input;

    for (int i = 2; i <= input; ++i)
    {
        count(i);
    }

    for (int i = 0; i < count_2; ++i)
    {
        test *= 2;
    }
    for (int i = 0; i < count_5; ++i)
    {
        test *= 5;
    }

    while (test % 10 == 0)
    {
        ++count_0;
        test /= 10;
    }

    std::cout << count_0 << std::endl;


    std::cin >> input;
    return 0;
}

void count(long long n)
{
    while (n > 1)
    {
        if (n % 5 == 0)
        {
            n /= 5;
            ++count_5;
        }
        else if (n % 2 == 0)
        {
            n /= 2;
            ++count_2;
        }
        else
        {
            break;
        }
    }
}