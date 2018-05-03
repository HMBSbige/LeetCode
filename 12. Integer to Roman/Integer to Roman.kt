class Solution
{
	fun intToRoman(num:Int):String
	{
		var m = arrayOf(1000 to "M", 900 to "CM", 500 to "D", 400 to "CD", 100 to "C", 90 to "XC", 50 to "L", 40 to "XL", 10 to "X", 9 to "IX", 5 to "V", 4 to "IV", 1 to "I")
		var n = num
		var res = ""
		while(n > 0)
		{
			var t:Pair<Int, String> = 0 to "F"
			for(value in m)
			{
				if(n >= value.first)
				{
					t = value
					break
				}
			}
			res += t.second
			n -= t.first
		}
		return res
	}
}
//Runtime: 300 ms