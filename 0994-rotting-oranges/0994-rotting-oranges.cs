public class Solution {
    public int OrangesRotting(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        Queue<(int row, int col)> q = new();
        int freshCount = 0;
        int minutes = 0;

        // collect all rotten oranges + count fresh ones
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 2)
                    q.Enqueue((i, j));
                else if (grid[i][j] == 1)
                    freshCount++;
            }
        }

        // no fresh oranges from the beginning
        if (freshCount == 0)
            return 0;

        int[][] directions =
        [
            [-1, 0], // up
            [1, 0],  // down
            [0, -1], // left
            [0, 1]   // right
        ];

        while (q.Count > 0)
        {
            int size = q.Count;
            bool rottedThisMinute = false;

            for (int i = 0; i < size; i++)
            {
                var (row, col) = q.Dequeue();

                foreach (var dir in directions)
                {
                    int newRow = row + dir[0];
                    int newCol = col + dir[1];

                    if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= cols)
                        continue;

                    if (grid[newRow][newCol] != 1)
                        continue;

                    grid[newRow][newCol] = 2;
                    freshCount--;
                    q.Enqueue((newRow, newCol));
                    rottedThisMinute = true;
                }
            }

            if (rottedThisMinute)
                minutes++;
        }

        return freshCount == 0 ? minutes : -1;
    }


}


// [[2,1,1],[0,1,1],[1,0,1]]


/*  
    X   O   O
        O   O
    O       O
*/