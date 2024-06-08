public class Solution {
    public string ReverseWords(string s) {
        var sb = new StringBuilder();
        var array = s.Split();
        for (int i = array.Length - 1; i > 0; i--)
        {
            if (array[i].Length > 0)
                sb.Append(array[i]+" ");
        }
        if (array[0].Length > 0)
            sb.Append(array[0]);
        else
            sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }
}