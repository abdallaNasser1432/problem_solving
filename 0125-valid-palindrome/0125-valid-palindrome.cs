public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, h = s.Length - 1;
        while (l < h)
        {
            if (!char.IsAsciiLetterOrDigit(s[l])) l++;
            else if (!char.IsAsciiLetterOrDigit(s[h])) h--;
            else
            {
                if (char.ToLower(s[l++]) != char.ToLower(s[h--])) return false;
            }
        }
        return true;
    }
}