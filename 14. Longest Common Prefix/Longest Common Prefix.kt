class Solution
{
	fun longestCommonPrefix(strs:Array<String>):String
	{
		if(strs.isEmpty()) return ""
		else if(strs.size == 1) return strs[0]

		//strs.sort()
		var templatestr = strs[0];
		var sb = StringBuilder(templatestr.length)
		for(c in templatestr)
		{
			sb.append(c)
			for(str in strs)
			{
				if(!str.startsWith(sb))
				{
					return sb.dropLast(1).toString()
				}
			}
		}
		return sb.toString()
	}
}
//Runtime: 240 ms