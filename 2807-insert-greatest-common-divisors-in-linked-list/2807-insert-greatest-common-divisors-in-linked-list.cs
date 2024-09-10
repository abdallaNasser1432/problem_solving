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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        if (head == null || head.next == null) return head;
        var fast = head;
        var slow = head.next;
        while(fast!=null && fast.next != null)
        {
            ListNode gcd = new(findGCD(fast.val, slow.val));
            fast.next = gcd;
            gcd.next = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        return head;
    }
    private int findGCD(int a, int b)
    {
        if (b == 0)
            return a;
        return findGCD(b, a % b);
    }
}