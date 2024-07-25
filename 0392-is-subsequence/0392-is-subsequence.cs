public class Solution {
    public bool IsSubsequence(string s, string t) {
        int lt = 0, ls = 0, ht = t.Length - 1, hs = s.Length - 1;
        while(lt <= ht && ls<=hs)
        {
            if(lt==ht && ls != hs)
            {
                lt++ ; ht--;
                continue;
            }
            if (t[lt++] == s[ls]) ls++;
            if (t[ht--] == s[hs]) hs--;
        }
        if (ls > hs)
            return true;
        return false;
    }
}