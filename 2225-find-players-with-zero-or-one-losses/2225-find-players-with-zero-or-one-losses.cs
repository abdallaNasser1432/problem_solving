public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        IDictionary<int,int>freq = new Dictionary<int,int>();
        IList<IList<int>>result = new List<IList<int>>();
        List<int>winners=new List<int>();
        List<int>loser=new List<int>();
        foreach (int[] match in matches)
        {
            if (freq.ContainsKey(match[1]))
                freq[match[1]]++;
            else
                freq.Add(match[1], 1);
            if (!freq.ContainsKey(match[0]))
                freq.Add(match[0], 0);
        }
        foreach (var item in freq)
        {
            if (item.Value == 0)
                winners.Add(item.Key);
            else if (item.Value == 1)
                loser.Add(item.Key);
        }
        winners.Sort(); loser.Sort();
        result.Add(winners); result.Add(loser);
        return result;
    }
}