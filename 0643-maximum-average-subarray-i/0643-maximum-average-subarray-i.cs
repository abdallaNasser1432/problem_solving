public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double sum = 0;
        double maxAverage = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if(i>=k-1)
            {
                maxAverage = Math.Max(maxAverage, sum / k);
                sum -= nums[i-(k-1)];
            }
        }
        return maxAverage;
    }
}