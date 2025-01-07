public class Solution {
    public IList<string> StringMatching(string[] words) {
        IList<string> result = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = i+1; j < words.Length; j++)
            {
                if (words[i].Length > words[j].Length)
                {
                    if (words[i].Contains(words[j]))
                    {
                        result.Add(words[j]);
                    }
                }
                else
                {
                    if (words[j].Contains(words[i]))
                    {
                        result.Add(words[i]);
                        break;
                    }
                }
            }
        }
        return result.Distinct().ToList();
    }
}