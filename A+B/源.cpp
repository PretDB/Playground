#include <iostream>
#include <bitset>

using namespace std;

/* 
    A    B    Cin    R    Cout
	0    0    0      0    0
	1    0    0      1    0
	0    1    0      1    0
	1    1    0      0    1
	0    0    1      1    0
	1    0    1      0    1
	0    1    1      0    1
	1    1    1      1    1
	*/	
int main()
{
	int a, b = 0;
	bool carry = false;
	bitset<32> bsA, bsB;
	bitset<32> bsR;

	while (true)
	{
		carry = false;
		cout << "Input: a = ";
		cin >> a;
		cout << ", b = ";
		cin >> b;
		cout << endl;

		bsA = bitset<32>(a);
		bsB = bitset<32>(b);
		bsR = bitset<32>(0);

		cout << bsA.to_string() << endl;
		cout << bsB.to_string() << endl;


		for (int i = 0; i < 32; ++i)
		{
			bsR[i] = bsA[i] ^ bsB[i] ^ carry;
			carry = (bsA[i] & bsB[i]) | ( carry & ( bsA[i] ^ bsB[i]));
		}

		cout << "Output: " << bsR.to_string() << endl;
		cout << "Int: " << (int)bsR.to_ulong() << endl;
	}


	cin >> a;
	return 0;
}