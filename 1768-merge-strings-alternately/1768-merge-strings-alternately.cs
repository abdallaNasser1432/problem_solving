public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder Merged = new StringBuilder();
        int p1 = 0, p2 = 0;
        while (p1 < word1.Length && p2 < word2.Length)
            Merged.Append(word1[p1++]).Append(word2[p2++]);
        if (p1 != word1.Length)
            Merged.Append(word1, p1, word1.Length - p1);
        else if (p2 != word2.Length)
            Merged.Append(word2, p2, word2.Length - p2);
        return Merged.ToString();
    }
}