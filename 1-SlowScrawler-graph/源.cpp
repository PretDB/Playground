#include <cstdio>
#include <iostream>
#include <vector>
#include <algorithm>
#include <deque>
#include <map>
#include <set>

using namespace std;

class Page
{
public:
	int response;
	int id;
	vector<Page> links_to;

	Page(int i, int r) : id(i), response(r)
	{
	}
};

class PageCompare
{
public:
	bool operator()(const Page& p1, const Page& p2) const
	{
		return p1.id < p2.id;
	}
};


int main()
{
	int groups_count = 0;
	vector<Page> pages;

	scanf("%d", &groups_count);

	for (; groups_count > 0; --groups_count)
	{
		int pages_count = 0;
		float discover_rate = 0.0;
		int expected_pages = 0;

		scanf("%d %f", &pages_count, &discover_rate);
		discover_rate /= 100.0;
		expected_pages = pages_count * discover_rate;

		for (int p = 0; p < pages_count; ++p)
		{
			int response = 0;

			scanf("%d", &response);

			Page page(p + 1, response);
			pages.push_back(page);
		}
		for (int p = 0; p < pages_count; ++p)
		{
			int links_count = 0;
			
			scanf("%d", &links_count);

			for (; links_count > 0; --links_count)
			{
				int links_to = 0;
				scanf("%d", &links_to);

				auto to_page = find_if(pages.begin(), pages.end(), [links_to](Page pp) {return pp.id == links_to; });

				pages[p].links_to.push_back(*to_page);
			}
		}

		deque<Page> scan_queue;
		set<Page, PageCompare> scanned_pages;
		int expected_response = 0;

		scan_queue.push_back(pages[0]);

		for (; !scan_queue.empty(); )
		{
			// Scan the page in front of queue.
			Page current_page = scan_queue.front();
			scan_queue.pop_front();

			expected_response = max(expected_response,
				current_page.response + 1);

			// Prepare pages to be scanned.
			for (Page p : current_page.links_to)
			{
				// The next page is not scanned.
				if (scanned_pages.find(p) == scanned_pages.end())
				{
					Page tp = pages[p.id - 1];
					scan_queue.push_back(tp);
				}
			}

			scanned_pages.insert(current_page);

			if (scanned_pages.size() >= expected_pages)
			{
				cout << expected_response << endl;
				break;
			}
		}

		if (scanned_pages.size() < expected_pages)
		{
			cout << -1 << endl;
		}

		pages.clear();
	}


	return 0;
}
