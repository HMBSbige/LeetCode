class Solution
{
	private fun max(a:Int, b:Int):Int
	{
		if(a > b)
		{
			return a
		}
		return b
	}

	private fun min(a:Int, b:Int):Int
	{
		if(a < b)
		{
			return a
		}
		return b
	}

	fun maxArea(height:IntArray):Int
	{
		var ans = 0
		var i = 0
		var j = height.size - 1
		while(i < j)
		{
			ans = max(ans, min(height[i], height[j]) * (j - i))
			if(height[i] < height[j])
			{
				++i
			}
			else
			{
				--j
			}
		}
		return ans
	}
}
//Runtime: 260 ms