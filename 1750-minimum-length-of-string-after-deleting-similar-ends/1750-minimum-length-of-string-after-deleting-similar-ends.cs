public class Solution {
    public int MinimumLength(string s) {
        int n = s.Length;
        int i = 0;
        int j = n - 1;

        while (i < j) {
            if (s[i] == s[j]) {
                char ch = s[i];
                while (i < n && s[i] == ch)
                    i++;

                while (j > i && s[j] == ch)
                    j--;
            } else
                break;
        }

        return j - i + 1;
    }
}