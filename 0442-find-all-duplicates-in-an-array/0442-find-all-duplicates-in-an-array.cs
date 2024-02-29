public class Solution {
    public  IList<int> FindDuplicates(int[] nums)
{
    var resutl = new HashSet<int>(); int temp = 0;
    for (int i = 0; i < nums.Length; i++)
    {
       
        if (nums[i]-1 != i)
        {
            while (nums[i] - 1 != i && nums[i] != nums[nums[i] - 1])
            {
                temp = nums[i];
                nums[i] = nums[nums[i] - 1];
                nums[temp - 1] = temp;
            }
            
        } 
        if (nums[i] == nums[nums[i] - 1] && nums[i] - 1 != i) resutl.Add(nums[i]);
    }
    return resutl.ToList();
}
}