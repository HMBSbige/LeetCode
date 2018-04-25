public class Solution
{
	public bool IsMatch(string s, string p)
	{
		return System.Text.RegularExpressions.Regex.IsMatch(s, $@"^{p}$");
	}
}
//Runtime: 220 ms