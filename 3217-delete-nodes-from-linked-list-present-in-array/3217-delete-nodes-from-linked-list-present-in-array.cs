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
        var current = head;
        ListNode previous = null;
        HashSet<int> set = new(nums);
        while(current != null)
        {
            if (set.Contains(current.val))
            {
                if (previous == null)
                    head = head.next;
                else
                    previous.next = current.next;
            }
            else
                previous = current;
            current = current.next;
        }
        return head;
    }
}