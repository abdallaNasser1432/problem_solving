public class Solution {
    public  int CountPrefixSuffixPairs(string[] words){
        int count = 0;
        for (int i = 0; i < words.Length-1; i++)
        {
            for (int j = i+1; j < words.Length; j++)
            {
                count += (isPrefixAndSuffix(words[i], words[j])) ? 1 : 0;
            }
        }
        return count;
    }
    private  bool isPrefixAndSuffix(string str1,string str2)
        => str2.StartsWith(str1) && str2.EndsWith(str1);
    }