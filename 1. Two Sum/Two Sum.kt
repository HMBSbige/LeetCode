class Solution
{
	fun twoSum(nums:IntArray, target:Int):IntArray
	{
		var m = mutableMapOf<Int, Int>()
		for(i in 0 until nums.size)
		{
			var x=target-nums[i]
			if(m.containsKey(x))
			{
				return intArrayOf(m.getValue(x),i)
			}
			m[nums[i]]=i
		}
		throw IllegalArgumentException("""没找到""")
	}
}
//Runtime: 220 ms