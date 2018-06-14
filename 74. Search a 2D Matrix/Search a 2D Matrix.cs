public class Solution
{
	public bool SearchMatrix(int[,] matrix, int target)
	{
		var row = matrix.GetLength(0);
		var column = matrix.GetLength(1);
		if (row * column == 0)
		{
			return false;
		}
		var left = 0;
		var right = row - 1;
		while (left <= right)
		{
			var mid = left + ((right - left) >> 1);
			if (matrix[mid, 0] < target)
			{
				left = mid + 1;
			}
			else if (matrix[mid, 0] > target)
			{
				right = mid - 1;
			}
			else
			{
				return true;
			}
		}

		if (left == 0)
		{
			return false;
		}
		else
		{
			row = left - 1;
		}

		left = 0;
		right = column - 1;
		while (left <= right)
		{
			var mid = left + ((right - left) >> 1);
			if (matrix[row, mid] < target)
			{
				left = mid + 1;
			}
			else if (matrix[row, mid] > target)
			{
				right = mid - 1;
			}
			else
			{
				return true;
			}
		}
		return false;
	}
}
//Runtime: 128 ms