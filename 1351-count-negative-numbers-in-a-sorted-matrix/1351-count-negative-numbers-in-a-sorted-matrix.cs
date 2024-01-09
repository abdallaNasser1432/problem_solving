public class Solution {
    public int CountNegatives(int[][] grid) {
        int count = 0;
for (int i = 0; i < grid.Length; i++)
{
    int low = 0; int high = grid[i].Length-1;
    while(low < high)
    {
        if (grid[i][high]<0)
            count++;
        if (grid[i][low] < 0)
            count++;
        high--;low++;
    }
    if(high==low && grid[i][high] < 0)
    {
        count++;
    }
}
return count;
    }
}