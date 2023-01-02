class Solution {
public:
    bool wordPattern(string pattern, string s) {
    vector<string>ss;
    string temp; s.push_back(' ');
    unordered_map<char,string>matchChar;
    set<string>matchWord;
    for (char i : s) {
        if (i != ' ')
            temp+=i;

        else{
            ss.push_back(temp);
            temp="";
        }
    }
    if (ss.size() != pattern.size())
        return false;
    for (int i = 0; i < pattern.size(); ++i) {
        if (matchChar.find(pattern[i]) != matchChar.end()){
            if(matchChar[pattern[i]] != ss[i] )
                return false;
        }
        else{
            if(matchWord.count(ss[i])==1)
                return false;
            matchChar[pattern[i]]=ss[i];
            matchWord.insert(ss[i]);
        }
    }
    return true;
}
};