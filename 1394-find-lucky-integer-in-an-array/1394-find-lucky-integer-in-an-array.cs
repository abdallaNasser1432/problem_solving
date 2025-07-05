public class Solution {
    public int FindLucky(int[] arr) {
        Dictionary<int, int> map = new();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!map.ContainsKey(arr[i])) map[arr[i]] = 1;
            else
                map[arr[i]]++;
        }
        int max_freq = -1;
        foreach(var i in map)
        {
            if (i.Key == i.Value)
                max_freq = Math.Max(max_freq, i.Key);
        }
        return max_freq;
    }
}