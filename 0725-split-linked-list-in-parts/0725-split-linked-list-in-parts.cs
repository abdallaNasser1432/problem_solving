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
    public ListNode[] SplitListToParts(ListNode head, int k) {
            var res = new ListNode[k];
            var list = new List<ListNode>();

            while (head != null)
            {
                list.Add(head);
                head = head.next;
            }

            int i = 0;
            var rest = list.Count % k;
            var step = list.Count / k;

            for (int j = 0; j < res.Length; j++)
            {
                if(j >= list.Count)
                    break;

                res[j] = list[i];

                if (j < rest)
                    i += step + 1;
                else
                    i += step;

                list[i - 1].next = null;
            }

            return res;
    }
}