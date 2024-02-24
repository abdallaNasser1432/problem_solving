public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int>result= new List<int>();
        int[] freq = new int[nums.Length+1];
        for (int i = 0; i < nums.Length; i++) freq[nums[i]]++;

        for (int i = 1;i < freq.Length;i++)
        {
            if (freq[i] == 0)
            {
                result.Add(i);
            }
        }
        return result;
    }
}