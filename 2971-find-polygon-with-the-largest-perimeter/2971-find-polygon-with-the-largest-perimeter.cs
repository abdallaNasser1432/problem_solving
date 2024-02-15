public class Solution {
    public long LargestPerimeter(int[] nums){
        Array.Sort(nums);
        long[] perfixSum = new long[nums.Length];
        perfixSum[0] = nums[0];
        for (int i = 1; i < perfixSum.Length; i++) perfixSum[i] =nums[i] + perfixSum[i - 1];
        for (int i = perfixSum.Length - 1; i >= 2; i--)
        {
            if (nums[i] < perfixSum[i - 1])
                return perfixSum[i];
        }
        return -1;

        }
}