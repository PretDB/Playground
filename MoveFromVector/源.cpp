#include <iostream>
#include <vector>
#include <algorithm>
#include <functional>
#include <utility>

using namespace std;

class Page
{
public:
	unsigned int id = 0;
	vector<Page&> link_to;

	Page(unsigned int i);
};
bool lessId(const Page& page1, const Page& page2);
int main()
{
	unsigned int page_count = 0;
	vector<Page&> standalone_pages;

	cout << "Input page count: ";
	cin >> page_count;
	for (; page_count > 0; --page_count)
	{
		unsigned int id;
		Page page(id);
		standalone_pages.push_back(page);
	}
	sort(standalone_pages.begin(), standalone_pages.end(), lessId);

	cout << "Assosiating stage: " << endl;
	for (Page page : standalone_pages)
	{
		cout << "\tFor page " << page.id << ", how many links does it has? ";
		unsigned int links_count;
		cin >> links_count;
		
		for (unsigned int i; i < links_count; ++i)
		{
			cout << "\t\tFor link " << i << ", it links to page: ";
			unsigned int link_to;
			cin >> link_to;
			auto pos = find_if(standalone_pages.begin(), standalone_pages.end(),
				bind(equal_to<unsigned int>(), placeholders::_1, link_to));
			page.link_to.push_back(*pos);
		}
	}

}

Page::Page(unsigned int i) :id(i) {}
bool lessId(const Page& page1, const Page& page2)
{
	return page1.id < page2.id;
}