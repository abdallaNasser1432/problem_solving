public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '*')
                stack.Push(s[i]);
            if (s[i] == '*' && stack.Count != 0)
                stack.Pop();
        }
        StringBuilder result = new StringBuilder();
        foreach (var item in stack.ToArray())
        {
            result.Insert(0,item);
        }
        return result.ToString();
    }
}