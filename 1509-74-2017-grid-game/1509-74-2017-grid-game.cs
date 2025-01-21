public class Solution {
    public long GridGame(int[][] grid) {
        
        long firstRowSum = 0;

        foreach (int num in grid[0])
            firstRowSum += num;


        long secondRowSum = 0;
        long minimumSum = long.MaxValue;

        for (int turnIndex = 0; turnIndex < grid[0].Length; turnIndex++)
        {
            firstRowSum -= grid[0][turnIndex];
            minimumSum = Math.Min(
                minimumSum,
                Math.Max(firstRowSum, secondRowSum)
            );
            secondRowSum += grid[1][turnIndex];
        }

        return minimumSum;
    }
}