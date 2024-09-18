public class Solution {
    public bool WordPattern(string pattern, string s) {
        
        var words = s.Split();
        if (pattern.Length != words.Length) return false;
        Dictionary<char, string> map = new();
        for (int i = 0; i < pattern.Length; i++)
        {
            if (map.ContainsKey(pattern[i]) && map.ContainsValue(words[i]))
            {
                if (map[pattern[i]] != words[i])
                    return false;
            }
            else if (map.ContainsKey(pattern[i]) || map.ContainsValue(words[i]))
                return false;
            else
                map[pattern[i]] = words[i];
        }
        return true;
    }
}