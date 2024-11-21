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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode temp = new ListNode(0);
        temp.next = head;
        ListNode first = temp;
        ListNode second = temp;
        for(int i = 0; i <= n; i++)
        {
            first = first.next;
        }
        while(first != null)
        {
            first = first.next;
            second = second.next;
        }
        second.next = second.next.next;
        return temp.next;
    }
}