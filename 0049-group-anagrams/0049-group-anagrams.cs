public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, int> map = new Dictionary<string, int>();
        List<IList<string>> result = new List<IList<string>>();
        string temp;
        for (int i = 0; i < strs.Length; i++)
        {
            temp = String.Concat(strs[i].Order());
            if (map.ContainsKey(temp))
            {
                result[map[temp]].Add(strs[i]);
            }
            else
            {
                map.Add(temp, result.Count());
                result.Add([strs[i]]);
            }
        }
        return result;
    }
}