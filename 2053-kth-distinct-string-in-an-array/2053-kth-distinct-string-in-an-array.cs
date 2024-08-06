public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string,int>freq = new Dictionary<string,int>();
        int count = k;
        for (int i = 0; i < arr.Length; i++)
        {
            if (!freq.ContainsKey(arr[i]))freq.Add(arr[i], 1);
            else freq[arr[i]]++;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (freq[arr[i]] == 1 && k-- == 1) return arr[i];
        }
        return string.Empty;
    }
}