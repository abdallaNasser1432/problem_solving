public class Solution {
    public long LargestPerimeter(int[] nums){
        Array.Sort(nums);
        long[] perfixSum = new long[nums.Length];
        nums.CopyTo(perfixSum, 0);
        for (int i = 1; i < perfixSum.Length; i++) perfixSum[i] += perfixSum[i - 1];
        for (int i = perfixSum.Length - 1; i >= 2; i--)
        {
            if (perfixSum[i] - perfixSum[i - 1] < perfixSum[i - 1])
                return perfixSum[i];

        }
        return -1;

        }
}