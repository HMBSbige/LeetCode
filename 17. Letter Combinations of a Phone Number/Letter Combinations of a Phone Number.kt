class Solution
{
	fun letterCombinations(digits:String):List<String>
	{
		if(digits == "")
		{
			return emptyList()
		}
		val m = mapOf('2' to listOf('a', 'b', 'c'), '3' to listOf('d', 'e', 'f'), '4' to listOf('g', 'h', 'i'), '5' to listOf('j', 'k', 'l'), '6' to listOf('m', 'n', 'o'), '7' to listOf('p', 'q', 'r', 's'), '8' to listOf('t', 'u', 'v'), '9' to listOf('w', 'x', 'y', 'z'))
		val res = mutableListOf("")
		for(c in digits)
		{
			for(i in 0 until res.size)
			{
				val pre = res[0]
				res.removeAt(0)
				for(add_char in m[c]!!)
				{
					res.add(pre + add_char)
				}
			}
		}
		return res
	}
}
//Runtime: 224 ms