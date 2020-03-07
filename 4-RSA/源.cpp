#include <cstdio>
#include <iostream>
#include <cmath>

using namespace std;

long long power_mod(long long a, long long b, long long c);
long long gcdEx(long long a, long long b, long long& x, long long& y);
long long inv(long long m, long long n, long long& x, long long& y);
int main()
{
	const long long p = 23333;
	const long long q = 10007;
	const long long phi = (p - 1) * (q - 1);
	const long long n = p * q;
	long long d = 0;
	long long e = 0;
	long long c = 0;
	long long m = 0;

	scanf("%ld %ld", &e, &c);

	long long x = 0;
	long long y = 0;
	d = inv(e, phi, x, y);

	m = power_mod(c, d, n);
	printf("%lld", m);

	return 0;
}

long long power_mod(long long a, long long b, long long c)

{

	long long ans = 1;

	a = a % c;

	while (b > 0)

	{

		if (b % 2 == 1)

			ans = (ans * a) % c;

		b = b / 2;

		a = (a * a) % c;

	}

	return ans;

}

long long gcdEx(long long a, long long b, long long& x, long long& y)
{
	if (b == 0)
	{
		x = 1;
		y = 0;
		return a;
	}
	else
	{
		long long r = gcdEx(b, a % b, x, y);
		long long t = x;
		x = y;
		y = t - a / b * y;
		return r;
	}
}

long long inv(long long m, long long n, long long& x, long long& y)
{
	long long gcd = gcdEx(m, n, x, y);
	if (1 != gcd)
	{
		return -1;
	}
	else
	{
		return (x + n) % n;
	}
}