#include <cstdio>
#include <iostream>
#include <vector>
#include <algorithm>
#include <list>
#include <map>
#include <bitset>
#include <deque>
#include <limits>

using namespace std;

int main()
{
	int groups_count = 0;
	vector<vector<int>> page_distances;

	scanf("%d", &groups_count);
	for (; groups_count > 0; --groups_count)
	{
		int pages_count = 0;
		float discover_rate = 0.0f;
		int edges_count = 0;
		int expected_pages = 0;

		// Pages count and thier response.
		scanf("%d %f", &pages_count, &discover_rate);
		expected_pages = (int)(pages_count * discover_rate / 100);

		page_distances.assign(pages_count + 1, vector<int>());
		for (vector<int>& v : page_distances)
		{
			v.assign(pages_count + 1, numeric_limits<int>::max());
		}
		// Response time for each page.
		for (int p = 1; p <= pages_count; ++p)
		{
			int response = 0;
			scanf("%d", &response);

			for (vector<int>& to : page_distances)
			{
				to[p] = response;
			}
		}

		// Links to pages.
		for (int p = 1; p <= pages_count; ++p)
		{
			int links_count = 0;
			vector<bool> links_to;
			links_to.assign(pages_count + 1, false);

			scanf("%d", &links_count);

			for (; links_count > 0; --links_count)
			{
				int to = 0;
				scanf("%d", &to);
				links_to[to] = true;
			}

			for (int to_p = 0; to_p <= pages_count; ++to_p)
			{
				if (!links_to[to_p])
				{
					page_distances[p][to_p] = numeric_limits<int>::max();
				}
			}
		}
		for (int p = 0; p <= pages_count; ++p)
		{
			if (p != 1)
			{
				page_distances[0][p] = numeric_limits<int>::max();
			}
		}

		deque<int> scan_queue;
		int expected_response = 0;
		int scaned_pages = 0;
		int last_page = 0;
		vector<int> pages_scaned;

		scan_queue.push_back(1);
		for (; scan_queue.size() > 0; )
		{
			int page_to_scan = scan_queue[0];
			scan_queue.pop_front();

			for (int page_to = 1; page_to <= pages_count; ++page_to)
			{
				if (page_distances[page_to_scan][page_to] != numeric_limits<int>::max())
				{
					if (find(pages_scaned.begin(), pages_scaned.end(), page_to) == pages_scaned.end())
					{
						scan_queue.push_back(page_to);
						expected_response = max(expected_response,
							page_distances[page_to_scan][page_to] + 1);
					}
				}
			}

			pages_scaned.push_back(page_to_scan);
			last_page = page_to_scan;
			if (pages_scaned.size() >= expected_pages)
			{
				// Print current page expected response;
				cout << expected_response << endl;

				break;
			}
		}
		if (scan_queue.empty() && pages_scaned.size() < expected_pages)
		{
			cout << -1 << endl;
		}

		page_distances.clear();
	}

	return 0;
}
