public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        
        IList<IList<int>> result= new List<IList<int>>();
        int l, h;
        for (int i = 0; i < nums.Length-2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            l = i + 1; h = nums.Length - 1;
            while (l < h)
            {
                int sum = nums[i] + nums[l] + nums[h];
                if (sum == 0)
                {
                    result.Add([nums[i], nums[l], nums[h]]);
                    while (l < h && nums[l] == nums[l+1]) l++;
                    
                    while (l < h && nums[h] == nums[h-1]) h--;
                    l++;
                    h--;
                }
                else if (sum <0) l++;
                else h--;
            }
        }
        return result;
    }
}