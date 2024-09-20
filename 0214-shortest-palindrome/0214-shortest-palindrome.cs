public class Solution {
    public string ShortestPalindrome(string s) {
        
        int n = s.Length;
        if (n == 0)
            return s;

        int left = 0;
        for (int right = n - 1; right >= 0; right--)
            if (s[right] == s[left])
                left++;

        if (left == n)
            return s;

        string nonPalindromeSuffix = s.Substring(left);
        StringBuilder reverseSuffix = new StringBuilder(nonPalindromeSuffix.Length);
        for (int i = nonPalindromeSuffix.Length - 1; i >= 0; i--)
            reverseSuffix.Append(nonPalindromeSuffix[i]);

        return reverseSuffix.ToString() + ShortestPalindrome(s.Substring(0, left)) + nonPalindromeSuffix;
    }
}