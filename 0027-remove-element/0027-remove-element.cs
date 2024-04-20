public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
                nums[result++] = nums[i];
        }
        return result;
    }
}