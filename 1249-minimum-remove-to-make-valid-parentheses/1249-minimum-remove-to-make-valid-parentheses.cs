public class Solution {
        public string MinRemoveToMakeValid(string s)  {
        StringBuilder newString = new StringBuilder();
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ')' && count <= 0) continue;
            else if (s[i] == ')') count--;
            else if (s[i] == '(') count++;
            newString.Append(s[i]);
        }
        if (count > 0)
        {
            for (int i = newString.Length-1; count != 0; i--)
            {
                if (newString[i] == '(')
                {
                    count--;
                    newString.Remove(i, 1);
                }
            }
        }
        return newString.ToString();
    }
}