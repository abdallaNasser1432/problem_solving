public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!map.TryAdd(c, 1))
                map[c]++;
        }
        foreach (var item in t)
        {
            if (!map.ContainsKey(item)) return false;
            map[item]--;
        }
        return !map.Any(c => c.Value != 0);
    }
}