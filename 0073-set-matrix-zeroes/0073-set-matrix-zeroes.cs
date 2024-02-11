public class Solution {
    public void SetZeroes(int[][] matrix)
    {
        int n = matrix.Length; int m = matrix[0].Length;
        HashSet<int>row= new HashSet<int>();
        HashSet<int>col= new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            for (int j  = 0; j < m; j++)
            {
                if (matrix[i][j]== 0)
                {
                    row.Add(i);
                    col.Add(j);
                }
            }
        }
        foreach (var item in row)
        {
            for (int i = 0; i < m; i++)
            {
                matrix[item][i] = 0;
            }
        }
        foreach (var item in col)
        {
            for (int i = 0; i < n; i++)
            {
                matrix[i][item] = 0;
            }
        }
    }
}