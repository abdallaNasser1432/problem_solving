public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid)
{
    int rows = grid.Length;
    int cols = grid[0].Length;

    Queue<(int row, int col)> q = new();
    int steps = 1;

    if (grid[0][0] != 0 || grid[rows - 1][cols - 1] != 0)
        return -1;

    q.Enqueue((0, 0));
    grid[0][0] = 1;
    int[][] directions =
        [
            [-1, 0], // up
            [1, 0],  // down
            [0, -1], // left
            [0, 1],  // right
            [-1,1],  // top right
            [-1,-1], // top left
            [1,1],   // down right
            [1,-1]   // down left
        ];

    while (q.Count > 0)
    {
        int size = q.Count;

        for (int i = 0; i < size; i++)
        {
            var (row, col) = q.Dequeue();

            if (row == rows - 1 && col == cols - 1)
                return steps;

            foreach (var dir in directions)
            {
                int newRow = row + dir[0];
                int newCol = col + dir[1];

                if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= cols)
                    continue;

                if (grid[newRow][newCol] != 0)
                    continue;


                q.Enqueue((newRow, newCol));
                grid[newRow][newCol] = 1;

            }
        }
        steps++;
    }
    return -1;
}
}