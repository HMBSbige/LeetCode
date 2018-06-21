public class Solution
{
	public int FindPeakElement(int[] nums)
	{
		var left = 0;
		var right = nums.Length - 1;

		while (left < right)
		{
			var mid = left + ((right - left) >> 1);
			if (nums[mid] < nums[mid + 1])
			{
				left = mid + 1;
			}
			else
			{
				right = mid;
			}
		}
		return left;
	}
}
//Runtime: 112 ms