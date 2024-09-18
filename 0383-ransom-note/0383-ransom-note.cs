public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        Dictionary<char,int> map = new Dictionary<char,int>();
        foreach (char c in magazine)
        {
            if (!map.TryAdd(c, 1))
                map[c]++;
        }
        foreach (var item in ransomNote)
        {
            if (!map.ContainsKey(item)) return false;
            map[item]--;
        }
        return !map.Any(c => c.Value < 0);
    }
}