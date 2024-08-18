public class Solution {
    public int EqualPairs(int[][] grid) {
        int countPairs = 0,  n = grid.Length; bool flag = true; 
        for (int i = 0; i < n; i++)
        {
            for (int j = 0 ; j < n; j++)
            {
                flag = true;
                for (int k = 0; k < n; k++)
                {
                    if (grid[i][k] != grid[k][j])
                    {
                        flag = false;
                        break;
                    }

                }
                if(flag) countPairs++;
            }
        }
        return countPairs;
    }
}