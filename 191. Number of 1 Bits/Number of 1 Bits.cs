public class Solution
{
	public int HammingWeight(uint n)
	{
		var res = 0;
		while (n > 0)
		{
			if ((n & 1) == 1)
			{
				++res;
			}
			n >>= 1;
		}
		return res;
	}
}
//Runtime: 44 ms