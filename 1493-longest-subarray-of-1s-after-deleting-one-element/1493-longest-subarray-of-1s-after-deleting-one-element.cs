public class Solution {
    public int LongestSubarray(int[] nums) {
        int zeroCount = 0, longestOnes = 0, start = 0;
        for (int end = 0; end < nums.Length; end++)
        {
            if (nums[end] == 0) zeroCount++;
            while (zeroCount > 1)
            {
                if (nums[start++] == 0) zeroCount--;
            }
            longestOnes = Math.Max(longestOnes, end - start);
        }
        return longestOnes;
    }
}