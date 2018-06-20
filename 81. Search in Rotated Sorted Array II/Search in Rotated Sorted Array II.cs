public class Solution
{
	public bool Search(int[] nums, int target)
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
					return true;
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
					return true;
				}
				else
				{
					right = mid - 1;
				}
			}
			else if (nums[mid] == target)
			{
				return true;
			}
			else
			{
				--right;
			}
		}
		return false;
	}
}
//Runtime: 108 ms