public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder palindrome = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsAsciiLetterOrDigit(s[i]))
                palindrome.Append(char.ToLower(s[i]));
        }
        int l = 0, h = palindrome.Length - 1;
        while (l < h)
        {
            if(palindrome[l++] != palindrome[h--])return false;
        }
        return true;
    }
}