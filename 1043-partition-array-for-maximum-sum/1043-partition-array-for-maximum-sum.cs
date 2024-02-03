public class Solution {
    public int MaxSumAfterPartitioning(int[] arr, int k) {
        int N = arr.Length;
        int K = k + 1;

        int[] dp = new int[k + 1];
        Array.Fill(dp, 0);

        for (int start = N - 1; start >= 0; start--)
        {
            int currMax = 0;
            int end = Math.Min(N, start + k);

            for (int i = start; i < end; i++)
            {
                currMax = Math.Max(currMax, arr[i]);
                dp[start % K] = Math.Max(dp[start % K], dp[(i + 1) % K] + currMax * (i - start + 1));
            }
        }
        return dp[0];
    }
}