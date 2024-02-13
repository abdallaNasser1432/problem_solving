public class Solution {
    public int FindDuplicate(int[] nums) {
        bool[] visted = new bool[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (visted[nums[i]]) return nums[i];
            visted[nums[i]] = true;
        }
        return -1;
    }
}