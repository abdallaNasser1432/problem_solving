class Solution {
public:
    int minDeletionSize(vector<string>& strs) {
    int count =0; string temp,sorted;
    for (int i = 0; i < strs[0].size() ; ++i) {
        for (auto ch:strs)
            temp+=ch[i];
        sorted = temp;
        sort(temp.begin(),temp.end());
        if(sorted != temp)
            count++;
        temp="";
    }
    return count;
}
};