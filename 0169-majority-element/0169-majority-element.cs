public class Solution {
     public int MajorityElement(int[] nums)
{
    IDictionary<int,int> map = new Dictionary<int,int>();
    foreach(int num in nums)
    {
        if (map.ContainsKey(num)) map[num]++;
        else map.Add(num, 1);
    }
        
    foreach(var num in map)
    {
        if (num.Value > nums.Length / 2)
            return num.Key;
    }
    return 0;
}
        }
