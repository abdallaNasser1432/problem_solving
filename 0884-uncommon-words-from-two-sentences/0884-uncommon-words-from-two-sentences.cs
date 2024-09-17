public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        Dictionary<string, int> freq = new();
        foreach(string s in s1.Split())
        {
            if (!freq.TryAdd(s, 1))
                freq[s]++;
        }
        foreach (string s in s2.Split())
        {
            if (!freq.TryAdd(s, 1))
                freq[s]++;
        }
        var result = freq.Where(v => v.Value == 1).Select(v => v.Key).ToArray();

        return result;
    }
}