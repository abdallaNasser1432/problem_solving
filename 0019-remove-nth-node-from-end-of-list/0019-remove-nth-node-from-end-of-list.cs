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
        int count = 0;
        var curr = head;
        while (curr != null)
        {
            curr = curr.next;
            count++;
        }
        count -= n;
        ListNode? prev = null;
        curr = head;
        while (curr != null)
        {
            if (count-- == 0)
            {
                if(prev == null)
                {
                    head = head.next;
                    break;
                }
                else
                {
                    prev.next = curr.next;
                    break;
                }
            }
            prev = curr;
            curr = curr.next;
        }
        return head ;
    }
}