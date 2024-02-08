public class Solution {
    public int NumSquares(int n) {
        int[] dp = new int[n+1];
        Array.Fill(dp, n);
        for(int i = 1; i<=Math.Sqrt(n); i++)
            dp[i*i] = 1;
        
        for(int i=2; i<=n; i++) {
            for(int j=i-1; j>= i/2; j--) {
                dp[i] = Math.Min(dp[i], dp[j] + dp[i-j]);
            }
        }

        return dp[n];
    }
}