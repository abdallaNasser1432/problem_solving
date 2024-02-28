public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        
    if(m*n != original.Length)
        return Array.Empty<int[]>();
    int[][] result = new int[m][]; int count = 0;
    for (int i = 0; i < m; i++)
    {
        result[i] = new int[n];
        for (int j = 0; j < n; j++)
            result[i][j] = original[count++];
    }
    return result;
}
}