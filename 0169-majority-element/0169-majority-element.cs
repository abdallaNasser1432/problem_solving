public class Solution {
     public int MajorityElement(int[] nums)
        {
           Array.Sort(nums);
int n = nums.Length;
return nums[n / 2];
        }
}