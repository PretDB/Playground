#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	vector<int> list = { 1, 3, 4, 6, 23, 6, 3, 6, 7, 8 };

	sort(list.begin(), list.end());

	for (int l : list)
	{
		cout << l << "\t";
	}
	cout << endl;

	list.erase(list.begin() + 5);

	for (int l : list)
	{
		cout << l << "\t";
	}
	cout << endl;

	int a;
	cin >> a;
}