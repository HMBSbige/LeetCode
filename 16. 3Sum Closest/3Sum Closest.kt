class Solution
{
	private fun abs(x:Int):Int
	{
		val temp = x shr 31
		//return (x + temp) xor temp
		return (x xor temp) - temp
	}

	fun threeSumClosest(nums:IntArray, target:Int):Int
	{
		nums.sort()
		var res = Int.MAX_VALUE
		var pre = 0
		var now:Int
		for(i1 in 0 until nums.size - 2)
		{
			val v1 = nums[i1]
			if(i1 > 0 && v1 == nums[i1 - 1])
			{
				continue
			}
			for(i2 in i1 + 1 until nums.size - 1)
			{
				val v2 = nums[i2]
				if(i2 > i1 + 1 && v2 == nums[i2 - 1])
				{
					continue
				}
				for(i3 in i2 + 1 until nums.size)
				{
					val v3 = nums[i3]
					if(i3 > i2 + 1 && v3 == nums[i3 - 1])
					{
						continue
					}
					now = this.abs(v1 + v2 + v3 - target)
					if(res > now)
					{
						res = now
						pre = v1 + v2 + v3
					}
					if(res == 0)
					{
						return target
					}
				}
			}
		}
		return pre
	}
}
//Runtime: 296 ms