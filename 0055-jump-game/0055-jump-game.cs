public class Solution {
   public bool CanJump(int[] nums)
{
    int reach = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (reach < i) return false;

                if (reach < i + nums[i])
                    reach = i + nums[i];
                if(reach>=nums.Length-1)
                    return true;
            }
            
            return true;
}
}