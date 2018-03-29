auto io_speed_up = []() {
	std::ios::sync_with_stdio(false);
	cin.tie(nullptr);
	return nullptr;
}();
class Solution {
public:
	vector<int> twoSum(vector<int>& nums, int target) {
		map<int, int> m;
		for (int i = 0; i<nums.size(); ++i)
		{
			auto x = nums[i];
			const auto it = m.find(target - x);
			if (it != m.end())
			{
				vector<int> ans = { i, it->second };
				//sort(ans.begin(), ans.end());
				return ans;
			}
			m[x] = i;
		}
		const logic_error ex("没找到");
		throw std::exception(ex);
	}
};
//Runtime: 6 ms