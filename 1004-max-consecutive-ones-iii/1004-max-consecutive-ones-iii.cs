public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int maxOnes = 0, currentCount = 0, maxFlip, j;
        for (int i = 0; i < nums.Length; i++)
        {
            maxFlip = k; j = i;
            while(maxFlip>=0 && j < nums.Length)
            {
                if (nums[j] == 1) currentCount++;
                else
                {
                    if (--maxFlip < 0) break;
                    currentCount++;
                }
                j++;
            }
            maxOnes = Math.Max(maxOnes, currentCount);
            currentCount = 0;
        }
        return maxOnes;
    }
}