#include <cstdio>
#include <iostream>
#include <algorithm>
#include <vector>
#include <deque>

using namespace std;

int main()
{
	int person_count = 0;
	int faucet_count = 0;
	vector<int> faucet;
	deque<int> queue;
	vector<int> time;

	scanf("%d %d", &person_count, &faucet_count);
	faucet.assign(faucet_count, 0);

	for (int p = 0; p < person_count; ++p)
	{
		int t = 0;
		scanf("%d", &t);
		queue.push_back(t);
	}

	if (faucet_count > person_count)
	{
		cout << 0 << endl;
	}
	else if (faucet_count == person_count)
	{
		auto shortest = min(time.begin(), time.end());
		cout << *shortest << endl;
	}
	else
	{
		for (int time_elapsed = 0; ; ++time_elapsed)
		{
			// Dequeue if any faucet is empty.
			for (int f = 0; f < faucet_count; ++f)
			{
				if (faucet[f] == 0)
				{
					if (queue.empty())
					{
						cout<< time_elapsed + 1 << endl;
						return 0;
					}
					else
					{
						faucet[f] = queue.front();
						queue.pop_front();
					}
				}
			}
			
			for_each(faucet.begin(), faucet.end(),
				[&](int& t) {--t; });
		}
	}
}