public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.TryAdd(nums[i], [i]))
            {
                if (map[nums[i]].Any(x => Math.Abs(x - i) <= k)) return true;
                map[nums[i]].Add(i);  
            }
        }
        return false;
    }
}