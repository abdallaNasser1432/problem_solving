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

        int startRow = 0, endRow = matrix.Length - 1, startCol = 0, endCol = matrix[0].Length - 1; 
        while (startRow <= endRow && startCol <= endCol && head != null)
        {
            for (int i = startCol; i <= endCol && startRow <= endRow && head != null; i++)
            {
                matrix[startRow][i] = head.val;
                head = head.next;
            }

            startRow++;
            for (int i = startRow; i <= endRow && startCol <= endCol && head != null; i++)
            {
                matrix[i][endCol] = head.val;
                head = head.next;
            }
            endCol--;
            for (int i = endCol; i >= startCol && startRow <= endRow && head != null; i--)
            {
                matrix[endRow][i] = head.val;
                head = head.next;
            }
            endRow--;
            for (int i = endRow; i >= startRow && startCol <= endCol && head != null; i--)
            {
                matrix[i][startCol] = head.val;
                head = head.next;
            }
            startCol++;
        }
        return matrix;
    }
}