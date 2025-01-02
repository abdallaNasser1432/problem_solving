public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u'];
        int[] perfix = new int[words.Length + 1];
        perfix[0] = 0;
        for (int i = 1; i < perfix.Length; i++)
        {
            perfix[i] = perfix[i - 1];
            if (vowels.Contains(words[i - 1][0]) &&
                vowels.Contains(words[i - 1][words[i - 1].Length - 1]))
                perfix[i]++;
        }
        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
            result[i] = perfix[queries[i][1] + 1] - perfix[queries[i][0]];


        return result;
    }
}
// 0 1 1 2 3 4 