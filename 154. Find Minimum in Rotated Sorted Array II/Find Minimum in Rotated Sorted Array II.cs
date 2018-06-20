public class Solution
{
	public int FindMin(int[] nums)
	{
		var left = 0;
		var right = nums.Length - 1;

		while (left <= right)
		{
			var mid = left + ((right - left) >> 1);
			if (nums[mid] > nums[right])
			{
				left = mid + 1;
			}
			else if (nums[mid] < nums[right])
			{
				right = mid;
			}
			else if (mid != right)
			{
				--right;
			}
			else
			{
				return nums[mid];
			}
		}

		throw new Exception(@"ERROR");
	}
}
//Runtime: 108 ms