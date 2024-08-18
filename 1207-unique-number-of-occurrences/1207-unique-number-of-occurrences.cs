public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int>freq = new Dictionary<int,int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (freq.ContainsKey(arr[i])) freq[arr[i]]++;
            else freq.Add(arr[i], 1);
        }
        HashSet<int> set = new HashSet<int>();
        foreach (var item in freq)
        {
            if (set.Contains(item.Value))
                return false;
            set.Add(item.Value);
        }
        return true;
    }
}