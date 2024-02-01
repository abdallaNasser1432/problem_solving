public class Solution {
        public  int[][] DivideArray(int[] nums, int k)
    {
        Array.Sort(nums);
        int[][] solution = new int[nums.Length/3][]; int iterator =0;
        if (nums[nums.Length - 1] - nums[nums.Length - 2] > k)
            return Array.Empty<int[]>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i + 2] - nums[i] >k)
                return Array.Empty<int[]>();
            solution[iterator++] = [nums[i],nums[i + 1],nums[i+2] ];
            i = i + 2; 
        }
        return solution;
    }
}