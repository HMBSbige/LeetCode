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
		var right = row * column - 1;
		while (left <= right)
		{
			var mid = left + ((right - left) >> 1);
			if (matrix[mid / column, mid % column] < target)
			{
				left = mid + 1;
			}
			else if (matrix[mid / column, mid % column] > target)
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
//Runtime: 136 ms