public class Solution {
    public int SingleNumber(int[] nums) 
    {
        int output =0;
        foreach(int n in nums)
            output = output ^ n;

        return output;
    }
}