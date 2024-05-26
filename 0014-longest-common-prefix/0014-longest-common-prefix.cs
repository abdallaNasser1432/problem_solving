public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder longPerfix = new StringBuilder();
        Array.Sort(strs);
        string first = strs[0];
        string last = strs[strs.Length - 1];
        for (int i = 0; i < Math.Min(first.Length, last.Length); i++)
        {
            if (first[i] != last[i]) return longPerfix.ToString();
            longPerfix.Append(first[i]);
        }
        return longPerfix.ToString();
    }
}