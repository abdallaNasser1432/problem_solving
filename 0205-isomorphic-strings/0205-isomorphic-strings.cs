public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,List<int>> freqS = new Dictionary<char,List<int>>();
        Dictionary<char,List<int>> freqT = new Dictionary<char,List<int>>();
        for (int i = 0; i < s.Length; i++)
        {
            if (freqS.ContainsKey(s[i])) freqS[s[i]].Add(i);
            else freqS.Add(s[i], [i]);

            if (freqT.ContainsKey(t[i])) freqT[t[i]].Add(i);
            else freqT.Add(t[i], [i]);
        }
        for (int i = 0;i < s.Length; i++)
        {
            if (!freqS[s[i]].SequenceEqual(freqT[t[i]])) return false;
        }
        return true;
    }
}