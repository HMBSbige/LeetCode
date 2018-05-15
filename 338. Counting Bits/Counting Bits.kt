class Solution
{
	fun countBits(num:Int):IntArray
	{
		val res = IntArray(num + 1)
		for(i in 1..num)
		{
			res[i] = res[i.shr(1)] + (i.and(1))
		}
		return res
	}
}
//Runtime: 256 ms