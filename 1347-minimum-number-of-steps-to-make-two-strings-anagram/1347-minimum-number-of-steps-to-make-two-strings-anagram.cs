public class Solution {
    public int MinSteps(string s, string t)
{
    int minSteps = 0;
    IDictionary<char, int> freqOfS = new Dictionary<char, int>();
    for (int i = 0; i < s.Length; i++)
    {
        if (freqOfS.ContainsKey(s[i])) freqOfS[s[i]]++;
        else

            freqOfS.Add(s[i], 1);
    }
    for (int i = 0; i < s.Length; i++)
    {
        if (freqOfS.ContainsKey(t[i]) && freqOfS[t[i]] > 0)
        {
            freqOfS[t[i]]--;
        }
        else
            minSteps++;
    }
    return minSteps;
}
}