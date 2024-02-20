public class Solution {
    public  int FirstMissingPositive(int[] nums)
{
    var postiveNumbers = new SortedSet<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0) postiveNumbers.Add(nums[i]);
    }
    int j = 0;
    foreach (var item in postiveNumbers)
    {
        if (item != ++j)
            return j;
    }
    return ++j;
}
}