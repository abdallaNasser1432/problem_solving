public class Solution {
    public  string CustomSortString(string order, string s){
        
        Dictionary<char,int> dict = new Dictionary<char,int>();
        StringBuilder sWithCusomOrderd = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
                dict[s[i]]++;
            else
                dict.Add(s[i], 1);
        }
        for (int i = 0; i < order.Length; i++)
        {
            if (dict.ContainsKey(order[i]))
            {
                sWithCusomOrderd.Append(order[i], dict[order[i]]);
                dict[order[i]] = 0;
            }
        }
        foreach (var item in dict)
        {
            if(item.Value > 0)
                sWithCusomOrderd.Append(item.Key, item.Value);
        }
        return sWithCusomOrderd.ToString();
    }
}