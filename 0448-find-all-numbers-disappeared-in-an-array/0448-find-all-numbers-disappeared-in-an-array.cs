public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int>result= new List<int>(); int temp = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int index = nums[i] - 1;
            while (nums[index] != index + 1)
            {
                temp = nums[index];
                nums[index] = index + 1;
                index = temp - 1;
            }
        }
        for (int i = 0;i < nums.Length;i++)
        {
            if (nums[i]!=i+1)
            {
                result.Add(i + 1);
            }
        }
        return result;
    }
}