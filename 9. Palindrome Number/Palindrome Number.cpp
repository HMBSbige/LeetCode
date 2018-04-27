auto io_speed_up = []()
{
	std::ios::sync_with_stdio(false);
	cin.tie(nullptr);
	return nullptr;
}();
class Solution
{
public:
	bool isPalindrome(int x)
	{
		if (x < 0)
		{
			return false;
		}
		if (x < 10)
		{
			return true;
		}
		vector<int> m(static_cast<int>(log10(x)) + 1);
		for (auto &xx : m)
		{
			xx = x % 10;
			x /= 10;
		}
		auto n(m);
		reverse(n.begin(), n.end());
		return n == m;
	}
};
//Runtime: 159 ms