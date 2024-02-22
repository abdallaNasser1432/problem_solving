public class Solution {
    public int FindJudge(int n, int[][] trust){
        
        int[] isTrusted = new int[n+1];
        for (int i = 0; i < trust.Length; i++)
        {
            isTrusted[trust[i][1]]++;
            isTrusted[trust[i][0]]--;
        }
        for (int i = 1; i <=n; i++)
        {
            if (isTrusted[i]==n-1)
                return i;
        }
        return -1;
    }
}