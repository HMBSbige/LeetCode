class Solution
{
	private fun abs(x:Long):Long
	{
		val temp = x shr 63
		return (x xor temp) - temp
	}

	fun divide(dividend:Int, divisor:Int):Int
	{
		if(dividend == Int.MIN_VALUE && divisor == -1)
		{
			return Int.MAX_VALUE
		}
		val flag = (dividend < 0).xor(divisor < 0)
		var l = abs(dividend.toLong())
		val r = abs(divisor.toLong())
		var res = 0L

		while(l >= r)
		{
			var a = r
			var b = 1L
			while(a.shl(1) <= l)
			{
				a = a.shl(1)
				b = b.shl(1)
			}
			res += b
			l -= a
		}
		return if(flag)
		{
			-res.toInt()
		}
		else
		{
			res.toInt()
		}
	}
}
//Runtime: 200 ms