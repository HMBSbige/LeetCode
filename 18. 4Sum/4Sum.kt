class Solution
{
	fun fourSum(nums:IntArray, target:Int):List<List<Int>>
	{
		val ans = emptyList<List<Int>>().toMutableSet()
		nums.sort()
		for(i1 in 0 until nums.size - 3)
		{
			val v1 = nums[i1]
			if(i1 >= 1 && v1 == nums[i1 - 1])
			{
				continue
			}
			for(i2 in i1 + 1 until nums.size - 2)
			{
				val v2 = nums[i2]
				if(i2 > i1 + 1 && v2 == nums[i2 - 1])
				{
					continue
				}
				val m = mutableSetOf<Int>()
				for(i3 in i2 + 1 until nums.size)
				{
					val v3 = nums[i3]
					if(!m.contains(target - v1 - v2 - v3))
					{
						m.add(v3)
					}
					else
					{
						ans.add(listOf(v1, v2, v3, target - v1 - v2 - v3))
					}
				}
			}
		}
		return ans.toList()
	}
}
//Runtime: 832 ms