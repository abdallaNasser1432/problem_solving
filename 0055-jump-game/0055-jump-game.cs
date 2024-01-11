public class Solution {
    public bool CanJump(int[] nums)
{

    for (int reach = 0, i = 0; i < nums.Length; i++)
    {
        if (reach < i)
            return false;

        reach = Math.Max(reach, nums[i] + i);

        if (reach >= nums.Length - 1)
            return true;
    }

    return true;
}

}