public class Solution {
    public int CountPartitions(int[] nums) {
        
        int totalSum = nums.Sum();
               

        int leftSum = 0;
        int count = 0;

        for (int i = 0; i < nums.Length - 1; i++) { 
            leftSum += nums[i]; 
            int rightSum = totalSum - leftSum; 
  
            if ((leftSum % 2) == (rightSum % 2))
                count++; 
            
        }
        return count;
    }
}