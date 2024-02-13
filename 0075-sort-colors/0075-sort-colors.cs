public class Solution {
    public void SortColors(int[] nums) {
        int temp; int min; int minIndex=0;
        for (int i = 0; i < nums.Length; i++)
        {
            min = nums[i]; minIndex =i;
            for (int j = i; j < nums.Length; j++)
            {
                if (min > nums[j])
                {
                    min = nums[j]; minIndex = j;
                } 
            }
            temp = nums[i];
            nums[i] = min;
            nums[minIndex]= temp;
        }
}}