public class Solution {
    public int MaxProfit(int[] prices) {
        int minToBuy  = prices[0];
        int maxProfit = 0 ; 
        for(int i = 1; i< prices.Length ;i++){
            maxProfit = Math.Max(maxProfit,prices[i]-minToBuy);
            minToBuy = Math.Min(prices[i],minToBuy);  
        }
        return maxProfit;
    }
}