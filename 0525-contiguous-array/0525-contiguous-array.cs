public class Solution {
    public int FindMaxLength(int[] nums) {
       Dictionary<int,int> map = new();
        map[0] = -1;
        int sum = 0,ans = 0;

        for(int i = 0;i<nums.Length;i++)
        {
            sum+= nums[i]==0?-1:1;
            if(map.ContainsKey(sum))
                ans = Math.Max(ans, i-map[sum]);
            else
                map[sum] = i;
        }
        return ans; 
    }
}