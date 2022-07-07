/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode curr = head;
        //find # of nodes in linkedList
        int count = 0;
        while (curr != null)
        {
            count++;
            curr = curr.next;
        }
        curr = head;
        
        //# of nodes in linkedList / 2 to find middle point
        //int 5/2 = 2;
        for(int i = 0; i < count/2; i++)
        {
            curr = curr.next;
        }
        return head = curr;
    }
}