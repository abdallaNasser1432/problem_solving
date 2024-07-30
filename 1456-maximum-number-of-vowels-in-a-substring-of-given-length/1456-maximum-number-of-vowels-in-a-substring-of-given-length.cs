public class Solution {
    public int MaxVowels(string s, int k) {
        char[] vowels = ['a', 'e', 'i', 'o', 'u'];
        int maxVowels = -1, currentCount = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Any(c => c == s[i])) currentCount++;
            if (i >= k - 1)
            {
                maxVowels=Math.Max(maxVowels,currentCount);
                if (vowels.Any(c => c == s[i - (k - 1)])) currentCount--;
            }
        }
        return maxVowels;
    }
}