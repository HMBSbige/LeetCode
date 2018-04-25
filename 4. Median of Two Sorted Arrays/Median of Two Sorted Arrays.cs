public class Solution
{
	public double FindMedianSortedArrays(int[] nums1, int[] nums2)
	{
		var a = new int[nums1.Length + nums2.Length];
		nums1.CopyTo(a,0);
		nums2.CopyTo(a,nums1.Length);
		Array.Sort(a);
		if ((a.Length & 1) == 0)//偶数
		{
			return (Convert.ToDouble(a[a.Length >> 1]) + Convert.ToDouble(a[(a.Length >> 1) - 1])) / 2;
		}
		else
		{
			return Convert.ToDouble(a[a.Length >> 1]);
		}
	}
}
//Runtime: 160 ms