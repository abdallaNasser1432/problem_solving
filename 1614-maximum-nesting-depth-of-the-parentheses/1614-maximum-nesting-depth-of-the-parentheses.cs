public class Solution {
    public int MaxDepth(string s) {
        
        int count = 0;
        Stack<char>bracktes= new Stack<char>();
        foreach (var item in s)
        {
            if (item == '(') bracktes.Push('(');
            else if (item == ')')bracktes.Pop();
            count = Math.Max(bracktes.Count, count);
        }
        return count;
    }
}