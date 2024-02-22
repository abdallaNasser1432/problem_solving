public class Solution {
    public int FindJudge(int n, int[][] trust){
        
        Dictionary<int,int> isTrusted = new Dictionary<int,int>();
        for (int i = 0; i < trust.Length; i++)
        {
            if (isTrusted.ContainsKey(trust[i][0]))
                isTrusted[trust[i][0]]--;
            else
                isTrusted.Add(trust[i][0],-1);
            if (!isTrusted.ContainsKey(trust[i][1]))
                isTrusted.Add(trust[i][1],1);
            else
                isTrusted[trust[i][1]]++;
        }
        foreach (var item in isTrusted)
        {
            if (item.Value == n - 1)
                return item.Key;
        }
        return (isTrusted.Count == 0 && n==1)?1:-1;
    }
}