public class Solution
{
	public int[] TwoSum(int[] nums, int target)
	{
		var m = new Dictionary<int, int>();
		for (var i = 0; i < nums.Length; ++i)
		{
			var x = target - nums[i];
			if (m.ContainsKey(x))
			{
				return new[] { m[x], i };
			}
			m[nums[i]] = i;
		}
		throw new ArgumentException(@"找不到");
	}
}
//Runtime: 280 ms