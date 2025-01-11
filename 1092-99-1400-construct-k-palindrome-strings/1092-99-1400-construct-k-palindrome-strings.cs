public class Solution {
    public bool CanConstruct(string s, int k) {
        if (s.Length < k) return false;
        if (s.Length == k) return true;

        int[] freq = new int[26];
        foreach (char c in s)
         freq[c - 'a']++;

        int oddCount = freq.Count(c => c%2 != 0);

        return oddCount <= k ;
    }
}