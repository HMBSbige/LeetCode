auto io_speed_up = []() {
	std::ios::sync_with_stdio(false);
	cin.tie(nullptr);
	return nullptr;
}();
class Solution {
private:
	static string & replace_all_distinct(string& str, const string& old_value, const string& new_value)
	{
		for (string::size_type pos(0); pos != string::npos; pos += new_value.length()) {
			if ((pos = str.find(old_value, pos)) != string::npos)
				str.replace(pos, old_value.length(), new_value);
			else
				break;
		}
		return str;
	}
public:
	string longestPalindrome(string s) const
	{
		const string specical_char = "#";
		string str = specical_char;
		for (auto&x : s)
		{
			str.push_back(x);
			str += specical_char;
		}
		const auto n = str.size();
		size_t mx = 0, id = 0;
		vector<size_t> p(n, 1);
		for (size_t i = 1; i<n; ++i)
		{
			if (mx > i)
				p[i] = min(p[2 * id - i], mx - i);
			else
				p[i] = 1;
			while (i >= p[i] && i + p[i]<n && str[i + p[i]] == str[i - p[i]])
				++p[i];
			if (p[i] + i > mx)
			{
				mx = p[i] + i;
				id = i;
			}
		}
		const auto number_of_substring = *max_element(p.begin(), p.end()) - 1 ;
		if(number_of_substring&1)
		{
			const auto mid = max_element(p.begin(), p.end()) - p.begin() >> 1;
			const auto left_n = (number_of_substring - 1) >> 1;
			return s.substr(mid - left_n, number_of_substring);
		}
		else
		{
			const auto mid = max_element(p.begin(), p.end()) - p.begin();
			const auto left_n = number_of_substring;
			auto temp = str.substr(mid - left_n, number_of_substring << 1 | 1);
			return replace_all_distinct(temp,specical_char,"");
		}
	}
};
//Runtime: 6 ms