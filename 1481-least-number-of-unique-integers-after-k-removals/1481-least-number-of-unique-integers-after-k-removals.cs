public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) 
    {
        var freq = new Dictionary<int, int>();
        foreach(var num in arr)
        {
            if(!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
        }
        
        var counts = freq.Values.ToList();
        counts.Sort();
        for(int i = 0; i < counts.Count; i++)
        {
            if(k < counts[i])
                return counts.Count -i;
            k -= counts[i];
        }
        
        return 0;
    }
}