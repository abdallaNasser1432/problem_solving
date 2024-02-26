public class Solution {
    public  int[] SortedSquares(int[] nums)=> nums.Select(x => x * x).Order().ToArray();
}