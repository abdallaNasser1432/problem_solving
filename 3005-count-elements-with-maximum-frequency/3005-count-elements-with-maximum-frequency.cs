public class Solution {
    public int MaxFrequencyElements(int[] nums){
        
    int maxFreq = 0; Dictionary<int,int> freq = new Dictionary<int,int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (freq.ContainsKey(nums[i]))
            freq[nums[i]]++;    
        else
            freq.Add(nums[i], 1);
        maxFreq=Math.Max(maxFreq, freq[nums[i]]);
    }
    int count = 0;
    foreach (var item in freq)
    {
        if (item.Value == maxFreq)
            count += maxFreq;
    }
    return count;
}
}