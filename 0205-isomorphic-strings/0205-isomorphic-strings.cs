public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> freqS = new Dictionary<char,char>();
        HashSet<char> exist = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (freqS.ContainsKey(s[i]))
            {
                if (freqS[s[i]] != t[i])
                    return false;
            }
            else
            {
                if (exist.Contains(t[i]))
                    return false;
                freqS.Add(s[i], t[i]);
                exist.Add(t[i]);
            }
        }

        return true;
    }
}