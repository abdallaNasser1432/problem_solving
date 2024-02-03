public class Solution {
    public  IList<int> SpiralOrder(int[][] matrix)
{
    var spiral = new List<int>();
    int startRow = 0, endRow = matrix.Length - 1, startCol = 0, endCol = matrix[0].Length - 1;
    while (startRow <= endRow && startCol <= endCol)
    {
        for (int i = startCol; i <= endCol && startRow <= endRow; i++)
            spiral.Add(matrix[startRow][i]);

        startRow++;
        for (int i = startRow; i <= endRow && startCol <= endCol; i++)
            spiral.Add(matrix[i][endCol]);

        endCol--;
        for (int i = endCol; i >= startCol && startRow <= endRow; i--)
            spiral.Add(matrix[endRow][i]);

        endRow--;
        for (int i = endRow; i >= startRow && startCol <= endCol; i--)
            spiral.Add(matrix[i][startCol]);

        startCol++;
    }
    return spiral;
}
}