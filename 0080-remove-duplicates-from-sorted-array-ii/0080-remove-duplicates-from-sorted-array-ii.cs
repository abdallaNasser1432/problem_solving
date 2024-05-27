public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 1; bool twice = false;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1] && !twice)
            {
                nums[k++] = nums[i];
                twice = true;
            }
            else if (nums[i] != nums[i - 1])
            {
                nums[k++] = nums[i];
                twice = false;
            }
        }
        return k;
    }
}