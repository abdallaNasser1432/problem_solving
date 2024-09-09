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
    public ListNode DeleteMiddle(ListNode head) {
        if (head == null || head.next == null) {
            return null; 
        }
        int size = 0;
        var current = head;
        while (current != null)
        {
            size++;
            current = current.next;
        }
        var prev = new ListNode(-1,null); int mid = size / 2;
        current = head;
        while (current!= null)
        {
            if(mid-- == 0)
            {
                if (prev != null)
                    prev.next = current.next;
                break;
            }
            prev = current;
            current = current.next;
        }
        return head;
    }
}