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
    public ListNode ModifiedList(int[] nums, ListNode head) {
        HashSet<int> set = new(nums);
        for (ListNode current = head, previous = null; current != null; current = current.next)
        {
            if (set.Contains(current.val))
            {
                if (previous == null)
                    head = current.next;
                else
                    previous.next = current.next;
            }
            else
                previous = current;
        }
        return head;
    }
}