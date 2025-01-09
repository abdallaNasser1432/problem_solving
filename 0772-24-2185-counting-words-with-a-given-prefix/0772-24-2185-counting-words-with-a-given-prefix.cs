public class Solution {
    public int PrefixCount(string[] words, string pref) =>
        words.Count(c => c.StartsWith(pref));
}