public class Solution {
    public  int[] SortedSquares(int[] nums){
        int[] result = new int[nums.Length];
        int low = 0; int high = nums.Length-1;
        for (int i = high; i >= 0; i--)
        {
            if (Math.Abs(nums[low]) > Math.Abs(nums[high]))
                result[i] = nums[low] * nums[low++];
            else
                result[i] = nums[high] * nums[high--];
        }
        return result;
    }
}