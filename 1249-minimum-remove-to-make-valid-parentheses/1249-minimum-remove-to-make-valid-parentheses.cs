public class Solution {
        public string MinRemoveToMakeValid(string s)  {
        Stack<char> stack = new Stack<char>(); int count = 0;
        foreach (var item in s)
        {
            if (item == ')' && count <= 0) continue;
            else if (item == ')') count--;
            else if (item == '(') count++;
            stack.Push(item);
        }
        var array = stack.ToArray();
        if (count > 0)
        {
            for (int i = 0; count != 0; i++)
            {
                if (array[i] == '(')
                {
                    count--;
                    array[i] = '0';
                }
            }
        }
        StringBuilder newString = new StringBuilder();
        for (int i =array.Length-1; i >= 0; i--)
        {
            if (array[i] == '0') continue;
            newString.Append(array[i]);
        }
        return newString.ToString();
    }
}