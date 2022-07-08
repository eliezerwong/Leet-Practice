/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var set = new HashSet<ListNode>();
        ListNode curr = head;
        while(curr != null && curr.next != null)
        {
            if(set.Contains(curr))
            {
                return head = curr;
            }
            else
            {
                set.Add(curr);
            }
            curr = curr.next;
        }
        return null;
    }
}