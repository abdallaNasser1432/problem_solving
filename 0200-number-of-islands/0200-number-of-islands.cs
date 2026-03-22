public class Solution {
    public int NumIslands(char[][] grid) {
            if (grid == null || grid.Length == 0)
                return 0;

            int rows = grid.Length;
            int cols = grid[0].Length;
            int islands = 0;

            Queue<(int row, int col)> q = new();

            int[][] directions =
            [
                [-1, 0], // up
                [1, 0],  // down
                [0, -1], // left
                [0, 1]   // right
            ];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islands++;
                        q.Enqueue((i, j));
                        grid[i][j] = '0'; // mark visited

                        while (q.Count > 0)
                        {
                            var (row, col) = q.Dequeue();

                            foreach (var dir in directions)
                            {
                                int newRow = row + dir[0];
                                int newCol = col + dir[1];

                                if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= cols)
                                    continue;

                                if (grid[newRow][newCol] != '1')
                                    continue;

                                q.Enqueue((newRow, newCol));
                                grid[newRow][newCol] = '0'; // mark visited
                            }
                        }
                    }
                }
            }

            return islands;
    }
}