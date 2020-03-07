#include <iostream>
#include <map>
#include <array>
#include <list>
#include <set>
#include <vector>
#include <algorithm>
#include <cstdio>

using namespace std;
/*
Input

第 1 行输入 1 个整数 T (1≤T≤10)，表示一共有 T 组数据；

对于每一组数据:

    第 1 行输入 1 个整数 N (1≤N≤10000000)，表示有 Access Log 有 N 条数据；
    接下来 N 行，每行输入一个整数 t (0≤t且整数 t 不会超过uint64_t范围)，表示 Access Log 中的一条数据；
    接下来 1 行输入 1 个整数 M (1≤M≤1000000)，表示有 M 次查询；
    接下来 M 行，每行两个整数 b，e，表示查询 [b, e] 时间段内的访问次数 (0≤b≤e)，并且0 <= b <= e)， 并且 0≤b≤e)，并且b,e 不会超过uint64_t范围)。

注意： Access Log 中的时间戳并不能保证是有序的。

Output

对于每次询问输出一行，在该行输出一个整数 R，表示对应区间的访问次数。
*/

int main()
{
    const int records_list_size = 5242880;
    int groups_count = 0;
    int records_count = 0;
    int queries_count = 0;

    vector<unsigned long long> records;

    scanf("%lld", &groups_count);

    for (; groups_count > 0; --groups_count)
    {
        // Record stage.
        scanf("%lld", &records_count);
        for (int a = 0; a < records_count ; ++a)
        {
            unsigned long long timestamp = 0;
            scanf("%lld", &timestamp);
            records.push_back(timestamp);
        }
        sort(records.begin(), records.end());

        // Query stage.
        scanf("%lld", &queries_count);
        for (; queries_count > 0; --queries_count)
        {
            unsigned long long lower = 0;
            unsigned long long upper = 0;
            unsigned long long access_count = 0;
            scanf("%lld%lld", &lower, &upper);

            auto lower_in_records = lower_bound(records.cbegin(), records.cend(), lower);
            auto upper_in_recores = upper_bound(records.cbegin(), records.cend(), upper);

            if (upper_in_recores == records.end())
            {
                access_count = distance(lower_in_records, records.cbegin() + records.size());
            }
            else
            {
                access_count = upper_in_recores - lower_in_records;
            }
            cout << access_count << endl;
        }

        records.clear();
    }
}
