#include <algorithm>
#include <cstdio>
#include <iostream>
#include <set>
#include <vector>
#include "Node.h"

using namespace std;

int main()
{
	int hosts_count = 0;
	int targets_count = 0;
	int groups = 0;
	vector<Node, NodeSortCriterion> hosts;
	vector<int> targets;

	scanf("%d", &groups);
	for (; groups > 0; --groups);
	{
		int edges_count = 0;

		scanf("%d %d", &hosts_count, &targets_count);

		// Add the targets.
		for (int t = 0; t < targets_count; ++t)
		{
			int target_id = 0;

			scanf("%d", &target_id);
			
			hosts.push_back(*(new Node(target_id)));
			targets.push_back(target_id);
		}
		sort(targets.begin(), targets.end());
		// Add the rest hosts.
		for (int h = 0; h < hosts_count; ++h)
		{
			if (find(targets.begin(), targets.end(), h) == targets.end())
			{
				continue;
			}
			else
			{
				hosts.push_back(*(new Node(h)));
			}

		}
		sort(hosts.begin(), hosts.end());
		
		// Add edges.
		scanf("%d", &edges_count);
		for (; edges_count > 0; --edges_count)
		{
			int from_id, to_id = 0;
			scanf("%d %d", &from_id, &to_id);

			Node f(from_id);
			Node t(to_id);
			auto from = find(hosts.begin(), hosts.end(), f);
			auto to = find(hosts.begin(), hosts.end(), t);

			(*from).eighbors.insert(*to);
			
		}
	}
}