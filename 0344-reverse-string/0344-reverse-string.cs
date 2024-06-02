public class Solution {
    public void ReverseString(char[] s) {
        int r = 0,l=s.Length-1;
        char temp;
        while (r < l)
        {
            temp = s[r];
            s[r++] = s[l];
            s[l--] = temp;
        }
    }
}