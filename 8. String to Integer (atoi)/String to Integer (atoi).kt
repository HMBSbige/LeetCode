class Solution
{
	fun myAtoi(str:String):Int
	{
		var s = str.trimStart(' ')
		if(s.count() <= 1)
		{
			val nullableInt = s.toIntOrNull(10)
			return if(nullableInt == null)
			{
				0
			}
			else
			{
				nullableInt
			}
		}
		var flag = 1
		if(s[0] == '-' || s[0] == '+')
		{
			if(s[1] < '0' || s[1] > '9')
			{
				return 0
			}
			if(s[0] == '-')
			{
				flag = -1
			}
			s = s.removeRange(0, 1)
		}
		else if(s[0] < '0' || s[0] > '9')
		{
			return 0
		}
		var res = 0L
		for((index, value) in s.withIndex())
		{
			if(value < '0' || value > '9')
			{
				break
			}
			res *= 10
			res += value.toInt() - '0'.toInt()
			if(res > Int.MAX_VALUE)
			{
				return if(flag == 1)
				{
					Int.MAX_VALUE
				}
				else
				{
					Int.MIN_VALUE
				}
			}
		}
		return res.toInt() * flag
	}
}
//Runtime: 264 ms