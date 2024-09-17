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
    public bool HasCycle(ListNode head) {
        if (head == null)
            return false;
        
        ListNode node1 = head,
                 node2 = node1.next;
        
        while (node2 != null)
        {
            if (node1 == node2)
                return true;
            
            node1 = node1.next;
            node2 = node2.next?.next;
        }
        
        return false;
    }
}