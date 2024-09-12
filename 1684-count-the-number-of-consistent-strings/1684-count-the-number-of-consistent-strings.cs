public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int res=words.Length;
        bool[] alp=new bool[26];
        foreach(char x in allowed)
        alp[x-'a']=true;
        foreach(string word in words){
            foreach(char x in word){
                if(!alp[x-'a']){
                    res--;
                    break;
                }
            }
            } 
            return res; 
    }
}