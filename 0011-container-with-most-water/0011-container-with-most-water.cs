public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = -1;
        int l = 0, h = height.Length - 1;
        while (l < h)
        {
            maxArea = Math.Max(maxArea, Math.Min(height[l], height[h]) * (h - l));
            if (height[l] < height[h]) l++;
            else h--;
        }
        return maxArea;
    }
}