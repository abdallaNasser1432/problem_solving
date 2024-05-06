public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = nums.Length; int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            count = 0;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    k--;
                    nums[j] = 101;
                    count++;
                }
                else
                    break;
            }
            i += count;
        }
        Array.Sort(nums);
        return k;
    }
}