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
    public ListNode ReverseList(ListNode head) {
        //we are re-ordering which nodes point to which
        //empty node to point at 1st node
        ListNode curr = head;
        //null node since nothing before 1st node
        ListNode prev = null;
        //loop through the nodes as long as pointer not null
        while (curr != null)
        {
            //save the address of next node with a temp pointer
            ListNode next = curr.next;
            //set the next thing that curr points to to the previous node
            curr.next = prev;
            //set the previous pointer to curr
            prev = curr;
            //set curr pointer to same address as next (temp) pointer
            curr = next;
        }
        //prev points at the last node (before null) hence return head = prev so the head points at the last node, making it first
        return head = prev;
    }
}