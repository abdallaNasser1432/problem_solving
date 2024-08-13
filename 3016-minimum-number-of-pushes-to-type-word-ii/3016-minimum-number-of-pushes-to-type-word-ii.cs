public class Solution {
    public int MinimumPushes(string word) {
        
        int totalPushes = 0;
        int[] freq = new int[26];

        for (int i = 0; i < word.Length; i++) freq[word[i] - 'a']++;

        Array.Sort(freq, (a, b) => b.CompareTo(a));

        for (int i = 0; i < 26; i++)
        {
            if (freq[i] == 0) break;

            totalPushes += (i / 8 + 1) * freq[i];
        }

        return totalPushes;
    }
}