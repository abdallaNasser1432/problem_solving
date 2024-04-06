public class Solution {
    public  string MakeGood(string s){
        
    bool isDeleted = false, isGood = false;
    while (!isGood)
    {
        isDeleted = false;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (Math.Abs(s[i] - s[i + 1]) == 32)
            {
                isDeleted = true;
                s = s.Remove(i, 2);
                break;
            }
        }
        if (!isDeleted) isGood = true;
    }
    return s;
}
}