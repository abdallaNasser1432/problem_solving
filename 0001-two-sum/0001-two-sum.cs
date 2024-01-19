public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    IDictionary<int, int> map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (map.ContainsKey(target - nums[i]))
            return [ map[target - nums[i]], i ];
        if (!map.ContainsKey(nums[i]))
        map.Add(nums[i], i);
    }
    return [];
        }
}