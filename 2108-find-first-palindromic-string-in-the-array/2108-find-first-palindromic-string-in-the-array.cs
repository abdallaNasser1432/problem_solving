public class Solution {
    public  string FirstPalindrome(string[] words){
        
        for (int i = 0; i < words.Length; i++)
        {
            int l = 0, h = words[i].Length-1; 

            while(l<=h)
            {
                if (words[i][l] != words[i][h])
                    break;
                l++;
                h--;
            }
            if (l > h)
                return words[i];
        }
        return string.Empty; 
    }
}