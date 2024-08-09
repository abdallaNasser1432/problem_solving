public class Solution {
    public int NumMagicSquaresInside(int[][] grid){
    if (grid.Length * grid[0].Length < 9) return 0;
    int result = 0;
    for (int i = 0; i < grid.Length-2; i++)
    {
        for (int j = 0; j < grid[0].Length-2; j++)
            if (isMagicSquare(grid, i, j)) result++;
    }
    return result;
}

    private bool isMagicSquare(int[][] grid, int i, int j){
        
   
        int col1 = grid[i][j] + grid[i + 1][j] + grid[i + 2][j];
        int col2 = grid[i][j + 1] + grid[i + 1][j + 1] + grid[i + 2][j + 1];
        int col3 = grid[i][j + 2] + grid[i + 1][j + 2] + grid[i + 2][j + 2];
        int row1 = grid[i][j] + grid[i][j + 1] + grid[i][j + 2];
        int row2 = grid[i + 1][j] + grid[i + 1][j + 1] + grid[i + 1][j + 2];
        int row3 = grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2];
        int diag1 = grid[i][j] + grid[i + 1][j + 1] + grid[i + 2][j + 2];
        int diag2 = grid[i + 2][j] + grid[i + 1][j + 1] + grid[i][j + 2];
        if (
            (col1 == col2) &&
            (col1 == col3) &&
            (col1 == row1) &&
            (col1 == row2) &&
            (col1 == row3) &&
            (col1 == diag1) &&
            (col1 == diag2))
        {
            bool[]uniqe = new bool[10];
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (grid[i + r][j + c]==0 ||grid[i + r][j + c]>9 || uniqe[grid[i + r][j + c]]) return false;
                    uniqe[grid[i + r][j + c]] = true;
                }
            }
            return true;
        }
    return false;
}
}