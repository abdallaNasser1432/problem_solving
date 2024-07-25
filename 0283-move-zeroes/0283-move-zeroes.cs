public class Solution {
    public void MoveZeroes(int[] nums) {
        int pt = 0; int temp;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                temp = nums[i];
                nums[i] = 0;
                nums[pt++] = temp;
            }
        }
    }
}