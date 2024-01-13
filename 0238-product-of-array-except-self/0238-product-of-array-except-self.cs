public class Solution {
    public int[] ProductExceptSelf(int[] nums)
{
    int n = nums.Length;
    int[] res = new int[n];
    Array.Fill(res, 1);
    int right = 1;
    for (int i = 0; i < n; i++)
    {
        res[i] *= right;
        right *= nums[i];
    }
    right=1;
    for (int i = n - 1; i >= 0; i--)
    {
        res[i] *= right;
        right *= nums[i];
    }
    return res;
}
}