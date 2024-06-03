public class Solution {
    public int AppendCharacters(string s, string t) {
        int sIndex = 0, tIndex = 0;
        while (sIndex < s.Length && tIndex < t.Length)
        {
            if (s[sIndex] == t[tIndex]) tIndex++;
            sIndex++;
        }
        return t.Length - tIndex;
    }
}