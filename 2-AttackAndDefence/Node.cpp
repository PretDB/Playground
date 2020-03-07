#include <set>
#include "Node.h"

using namespace std;

Node::Node(int i) : id(i) {}

NodeSortCriterion::operator()(const Node& a, const Node& b)
{
	return a.id < b.id;
}