public class Solution {
    public int[] TwoSum(int[] nums, int target) {
           for (int i = 0; i < nums.Length; i++)
    {
        int indexOf = Array.IndexOf(nums, target - nums[i]);
        if (indexOf != -1 && indexOf != i)
            return new int[] { i, indexOf };
    }
    return new int[] {}; 
    }
}