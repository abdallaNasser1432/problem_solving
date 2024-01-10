public class Solution {
     public int MajorityElement(int[] nums)
        {
            int count = 0; int majorty = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    count++;
                    majorty = nums[i];
                }
                else if (majorty == nums[i])
                    count++;
                else
                    count--;
            }
            return majorty;
        }
}