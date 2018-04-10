public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{
		int max = 0, left = 0;
		var lenthofstring = s.Length;
		var m = new Dictionary<char, int>();
		for (int i = 0; i < lenthofstring; ++i)
		{
			char c = s[i];
			left = Math.Max(left,m.ContainsKey(c) ? m[c] + 1 : 0);
			max = Math.Max(max, i - left + 1);
			m[c]=i;
		}
		return max;
	}
}
//Runtime: 96 ms