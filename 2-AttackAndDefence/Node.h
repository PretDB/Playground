#include <set>

using namespace std;

class NodeSortCriterion
{
public:
	bool operator() (const Node& a, const Node& b);
};

class Node
{
public:
	set<Node&, NodeSortCriterion> eighbors;
	int id;

	Node(int i);
};
