public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Array.Sort(nums);
        int l = 0, h = nums.Length - 1, count = 0;
        while (l < h)
        {
            if (nums[l] + nums[h] == k)
            {
                count++;
                l++;
                h--;
            }
            else if (nums[l] + nums[h] > k) h--;
            else l++;
        }
        return count;
    }
}