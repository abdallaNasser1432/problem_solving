public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0;
        foreach (var item in nums)
        {
            if (i < 2 || item > nums[i - 2])
                nums[i++] = item;
        }
        return i;
    }
}