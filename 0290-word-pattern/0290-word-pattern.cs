public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Split();
        HashSet<string> strings = new(words);
        HashSet<char> chars = new(pattern.ToCharArray());
        if (pattern.Length != words.Length || strings.Count != chars.Count) return false;
        Dictionary<char, string> map = new();
        for (int i = 0; i < pattern.Length; i++)
        {
            if (map.ContainsKey(pattern[i]))
            {
                if (map[pattern[i]] != words[i])
                    return false;
            }
            else
                map[pattern[i]] = words[i];
        }
        return true;
    }
}