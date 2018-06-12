public class Solution
{
	public int[] SearchRange(int[] nums, int target)
	{
		var left = 0;
		var right = nums.Length - 1;
		while (left <= right)
		{
			var mid = left + ((right - left) >> 1);
			if (nums[mid] < target)
			{
				left = mid + 1;
			}
			else
			{
				right = mid - 1;
			}
		}
		var resLeft = left;

		left = 0;
		right = nums.Length - 1;
		while (left <= right)
		{
			var mid = left + ((right - left) >> 1);
			if (nums[mid] > target)
			{
				right = mid - 1;
			}
			else
			{
				left = mid + 1;
			}
		}
		var resRight = right;

		if (resLeft > resRight)
		{
			return new[] { -1, -1 };
		}
		return new[] { resLeft, resRight };
	}
}
//Runtime: 300 ms