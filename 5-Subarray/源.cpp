#include <cstdio>
#include <iostream>
#include <vector>
#include <unordered_map>
#include <algorithm>

using namespace std;

int subarray(vector<int>& A, int K);
int main()
{
    int groups_count = 0;
    vector<int> array;

    // Storage stage.
    scanf("%d", &groups_count);
    for (; groups_count > 0; --groups_count)
    {
        int nums_count = 0;
        scanf("%d", &nums_count);

        for (; nums_count > 0; --nums_count)
        {
            int n = 0;
            scanf("%d", &n);

            array.push_back(n);
        }

		cout << subarray(array, 3) << endl;
        array.clear();
    }

    return 0;
}


int subarray(vector<int>& nums, int k)
{
    int result = 0, cur_sum = 0;
    unordered_map<int, int> sum_dict = { {0, 1} };
    for (auto& num : nums)
    {
        cur_sum += num;
        result += sum_dict[cur_sum - k];
        sum_dict[cur_sum]++;
    }
    result = count_if(sum_dict.begin(), sum_dict.end(), [](auto s) { return s.first > 0 && s.second >= 0 && s.first % 3 == 0; });
    return result;
}
