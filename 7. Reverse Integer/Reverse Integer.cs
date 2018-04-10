public class Solution
{
	private static string ReveseStr(string str)
	{
		return new string(str.ToCharArray().Reverse().ToArray());
	}
	public int Reverse(int x)
	{
		int i = 1;
		var xx = Convert.ToString(x);
		if (xx[0] == '-')
		{
			i = -1;
			xx = xx.Remove(0,1);
		}
		string xStr = ReveseStr(xx);
		var res = Convert.ToInt64(xStr);
		if (res <= int.MaxValue)
		{
			return (int)res*i;
		}
		return 0;
	}
}
//Runtime: 48 ms