public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int windowEnd = 0, windowsStart = 0;
        for (; windowEnd < nums.Length; windowEnd++)
        {
            if (nums[windowEnd] == 0) k--;
            if (k < 0 && nums[windowsStart++] == 0) k++;
        }
        return windowEnd - windowsStart ; 
    }
}