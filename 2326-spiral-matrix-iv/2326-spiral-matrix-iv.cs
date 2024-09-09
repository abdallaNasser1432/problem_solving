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
    public int[][] SpiralMatrix(int m, int n, ListNode head) {
        int[][]matrix = new int[m][];
        for (int i = 0; i < m; i++)
        {
            matrix[i] = new int[n];
            Array.Fill(matrix[i], -1);
        }

        int startRow = 0, endRow = matrix.Length - 1, startCol = 0, endCol = matrix[0].Length - 1; ListNode current = head;
        while ( current != null)
        {
            for (int i = startCol; i <= endCol && startRow <= endRow && current != null; i++)
            {
                matrix[startRow][i] = current.val;
                current = current.next;
            }

            startRow++;
            for (int i = startRow; i <= endRow && startCol <= endCol && current != null; i++)
            {
                matrix[i][endCol] = current.val;
                current = current.next;
            }
            endCol--;
            for (int i = endCol; i >= startCol && startRow <= endRow && current != null; i--)
            {
                matrix[endRow][i] = current.val;
                current = current.next;
            }
            endRow--;
            for (int i = endRow; i >= startRow && startCol <= endCol && current != null; i--)
            {
                matrix[i][startCol] = current.val;
                current = current.next;
            }
            startCol++;
        }
        return matrix;
    }
}