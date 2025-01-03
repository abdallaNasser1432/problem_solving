public class Solution {
    public int WaysToSplitArray(int[] nums) {
        int numberOfVaildSplit = 0;
        long[] perfix = new long[nums.Length + 1];
        perfix[0] = 0;
        for (int i = 1; i < perfix.Length; i++)
        {
            perfix[i] = perfix[i - 1] + nums[i - 1];
        }
        for (int i = 1; i < perfix.Length - 1; i++)
        {
            numberOfVaildSplit += (perfix[i] >= perfix[perfix.Length - 1] - perfix[i]) ? 1 : 0;
        }
        return numberOfVaildSplit;
    }
}