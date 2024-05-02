public class Solution {
    public  string ReversePrefix(string word, char ch){
        int index = word.IndexOf(ch);
        if (index == -1) return word;
        StringBuilder revers = new StringBuilder();
        for (int i = index; i >= 0; i--)
            revers.Append(word[i]);
        revers.Append(word.Substring(index + 1));
        return revers.ToString();
    }
}