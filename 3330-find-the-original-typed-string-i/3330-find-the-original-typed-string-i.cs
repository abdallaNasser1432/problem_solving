public class Solution {
    public int PossibleStringCount(string word) {
        int count = 1;
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
                count++;   
        }
        return count;
    }
}