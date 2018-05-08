class Solution
{
	fun threeSum(nums:IntArray):List<List<Int>>
	{
		val ans = emptyList<List<Int>>().toMutableSet()
		nums.sort()
		for((index, value) in nums.slice(0 until nums.size - 2).withIndex())
		{
			if(index >= 1 && value == nums[index - 1])
			{
				continue
			}
			val m = mutableSetOf<Int>()
			for(x in nums.slice(index + 1 until nums.size))
			{
				if(!m.contains(x))
				{
					m.add(value.inv() + 1 - x)
				}
				else
				{
					ans.add(listOf(value, -value - x, x))
				}
			}
		}
		return ans.toList()
	}
}
//Runtime: 1288 ms