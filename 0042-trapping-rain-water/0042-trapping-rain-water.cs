public class Solution {
    public int Trap(int[] height) {
        int i = 0, lmax = height[0], sum = 0;
        int j = height.Length - 1, rmax = height[j];
        while (i < j)
        {
            lmax = Math.Max(lmax, height[i]);
            rmax = Math.Max(rmax, height[j]);
            sum += (lmax <= rmax)? (lmax - height[i++]): (rmax - height[j--]);
        }
        return sum;
    }
}