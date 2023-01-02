class Solution {
public:
   bool detectCapitalUse(string word) {
    if((int)word[0]<97){//capital
        bool small= false,capital=false;
        for (int i = 1; i <word.size() ; ++i) {
            if ((int)word[i]<97)
                capital= true;
            else
                small= true;
        }
        if((small and !capital) or (!small and capital) or (!small and !capital))
            return true;
        else
            return false;
    }
    else{//small
        for (int i = 1; i <word.size() ; ++i){
            if((int)word[i]<97)
                return false;
        }
        return true;
    }
    return true;
}
};