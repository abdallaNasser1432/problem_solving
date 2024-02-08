public class Solution {
public void Rotate(int[][] matrix){
    
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = i+1; j < matrix[0].Length; j++)
        {
            matrix[i][j] = matrix[i][j] + matrix[j][i];
            matrix[j][i] = matrix[i][j]- matrix[j][i];
            matrix[i][j] = matrix[i][j] - matrix[j][i];
        }
    }
    for (int i = 0;i < matrix.Length; i++)
        matrix[i] = matrix[i].Reverse().ToArray();
    }
}

/*



*/