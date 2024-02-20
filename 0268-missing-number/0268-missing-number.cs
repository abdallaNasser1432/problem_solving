public class Solution {
    public int MissingNumber(int[] nums){
    int sum = 0;
    for (int i = 0; i < nums.Length; i++) sum += nums[i];
    return (nums.Length * (nums.Length + 1) / 2) - sum;
    }
}