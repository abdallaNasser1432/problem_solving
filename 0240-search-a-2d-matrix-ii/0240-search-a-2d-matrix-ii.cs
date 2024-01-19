public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int m = matrix.Length; int n = matrix[0].Length;
        int low = 0; int high = n - 1;
        while(low<m && high>=0)
        {
            if (matrix[low][high] == target)
                return true;
            else if (matrix[low][high] > target)
                high--;
            else 
                low++;
        }
        return false;

    }
}