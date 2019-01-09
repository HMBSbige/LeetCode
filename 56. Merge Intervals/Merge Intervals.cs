public class Solution
{
	public IList<Interval> Merge(IList<Interval> intervals)
	{
		var list = intervals.ToList();
		list.Sort((a, b) => a.start - b.start);
		var res = new List<Interval>();
		foreach (var interval in list)
		{
			if (res.Count > 0 && res.Last().end >= interval.start)
			{
				res.Last().end = Math.Max(res.Last().end, interval.end);
			}
			else
			{
				res.Add(interval);
			}
		}
		return res;
	}
}
//Runtime: 424 ms