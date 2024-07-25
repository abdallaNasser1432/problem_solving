public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sp = 0; int tp = 0;
        while (sp < s.Length && tp < t.Length)
            if (s[sp] == t[tp++]) sp++;
        return sp == s.Length; 
    }
}