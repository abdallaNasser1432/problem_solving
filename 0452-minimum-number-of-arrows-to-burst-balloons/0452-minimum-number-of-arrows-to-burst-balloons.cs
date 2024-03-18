public class Solution {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));
        int end = points[points.Length-1][0], cnt = 1;
        for (int i = points.Length-2; i >=0 ; i--)
        {
            if (end > points[i][1])
            {
                cnt++;
                end = points[i][0];
            }
        }

        return cnt;
    }
}