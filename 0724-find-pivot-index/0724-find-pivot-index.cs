public class Solution {
    public int PivotIndex(int[] nums) {
        int total = nums.Sum();

        int leftTotal = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int rightTotal = total - leftTotal - nums[i];

            if (rightTotal == leftTotal)  return i;

            leftTotal += nums[i];
        }

        return -1;
    }
}



// 1  8  11  17  22  28