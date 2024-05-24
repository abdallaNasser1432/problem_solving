public class Solution {
    public int RomanToInt(string s)
    {
        int value = 0;
        Dictionary<char, int> roman = new Dictionary<char, int>() { { 'I', 1 },
                                                                    { 'V', 5 },
                                                                    { 'X', 10 },
                                                                    { 'L', 50 },
                                                                    { 'C', 100 },
                                                                    { 'D', 500 },
                                                                    { 'M', 1000 }};
        for (int i = 0; i < s.Length-1; i++)
            value = (roman[s[i]] < roman[s[i + 1]]) ? value - roman[s[i]] : value + roman[s[i]];

        return value + roman[s[s.Length-1]];
    }
}