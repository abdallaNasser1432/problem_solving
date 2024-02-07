public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        StringBuilder result = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (freq.ContainsKey(s[i])) freq[s[i]]++;
            else freq.Add(s[i], 1);
        }
        freq = freq.OrderByDescending(f => f.Value).ToDictionary();
        foreach (var item in freq)
        {
            for (int i = 0; i < item.Value; i++)
                result.Append(item.Key);
        }
        return result.ToString();
    }
}