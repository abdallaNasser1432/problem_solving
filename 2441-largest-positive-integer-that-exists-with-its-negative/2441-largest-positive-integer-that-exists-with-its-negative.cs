public class Solution {
    public  int FindMaxK(int[] nums){
        SortedSet<int> soretedNums = new SortedSet<int>(
            Comparer<int>.Create((x, y) =>y.CompareTo(x)));

        for (int i = 0; i < nums.Length; i++) soretedNums.Add(nums[i]);
        foreach (var item in soretedNums)
        {
            if (soretedNums.Contains(-1 * item))
                return item;
        } 
        return -1;
  }
}