/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		var res = new ListNode(0);
		var head = res;
		var re = 0;
		while (l1 != null || l2 != null)
		{
			var value = 0;
			if (l1 != null)
			{
				value = re + l1.val;
				re = 0;
			}
			if (l2 != null)
			{
				value += re + l2.val;
			}
			res.next=new ListNode(value%10);
			res = res.next;
			re = value / 10;
			l1 = l1?.next;
			l2 = l2?.next;
		}
		if (re > 0)
		{
			res.next = new ListNode(re);
		}
		return head.next;
	}
}
//Runtime: 128 ms