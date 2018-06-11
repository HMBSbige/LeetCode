public class Solution
{
	public int Search(int[] nums, int target)
	{

		var left = 0;
		var right = nums.Length - 1;

		while (left <= right)
		{
			var mid = left + ((right - left) >> 1);
			if (nums[mid] > nums[right])
			{
				if (target < nums[mid] && target >= nums[left])
				{
					right = mid - 1;
				}
				else if (target == nums[mid])
				{
					return mid;
				}
				else
				{
					left = mid + 1;
				}
			}
			else if (nums[mid] < nums[right])
			{
				if (target > nums[mid] && target <= nums[right])
				{
					left = mid + 1;
				}
				else if (target == nums[mid])
				{
					return mid;
				}
				else
				{
					right = mid - 1;
				}
			}
			else if (nums[mid] == target)
			{
				return mid;
			}
			else
			{
				return -1;
			}
		}
		return -1;
	}
}
//Runtime: 104 ms