public class Solution {
    public int CountSubstrings(string s) {
        int res = 0;
        
        for(int i=0; i<s.Length; i++)
        {
            res += CheckPalindrome(s, i, i) + CheckPalindrome(s, i, i+1);
        }
        
        return res;
    }
    
    public int CheckPalindrome(string s, int start, int end)
    {
        int count = 0;
        while(start >= 0 && end < s.Length && s[start] == s[end])
        {
            count++;
            start--;
            end++;
        }
        return count;
    }
}