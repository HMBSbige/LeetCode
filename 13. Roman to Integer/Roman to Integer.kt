class Solution
{
	fun romanToInt(s:String):Int
	{
		var m = mapOf('I' to 1, 'V' to 5, 'X' to 10, 'L' to 50, 'C' to 100, 'D' to 500, 'M' to 1000)
		var res = 0
		var last = Int.MAX_VALUE
		var now = 0
		for(value in s)
		{
			m[value]?.let { now = it }
			res += now
			if(now > last)
			{
				res -= 2 * last
			}
			last = now
		}
		return res
	}
}
//Runtime: 328 ms