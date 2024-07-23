public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int max = int.MaxValue, min = int.MaxValue;
        foreach (var item in nums)
        {
            if (item <= min) min = item;
            else if (item <= max) max = item;
            else return true;
        }
        return false; 
    }
}