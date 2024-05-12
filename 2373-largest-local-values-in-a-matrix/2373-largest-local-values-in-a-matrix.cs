public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        int n = grid.Length;
        int[][] res = new int[n - 2][];
        
        for (int i = 0; i < n - 2; i++)
        {
            res[i] = new int[n - 2];
            
            for (int j = 0; j < n - 2; j++)
            {
                res[i][j] = 0;
                
                for (int k = i; k < i + 3; k++)
                {
                    for (int l = j; l < j + 3; l++)
                    {
                        res[i][j] = Math.Max(res[i][j], grid[k][l]);
                    }
                }
            }
        }
        
        return res;
    }
}