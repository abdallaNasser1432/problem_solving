public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0; 
        for (int i = s.Length-1; i >= 0; i--)
        {
            if (s[i] == ' ' && count != 0)
                return count;
             if (s[i] != ' ' )
                 count++;
        }
        return count;
    }
}