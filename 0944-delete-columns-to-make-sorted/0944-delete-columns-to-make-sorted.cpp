class Solution {
public:
int minDeletionSize(vector<string>& strs) {
    int count =0; int Max=-1;
    for (int i = 0; i < strs[0].size() ; ++i) {
        for (auto ch:strs){
            Max=max(Max,(int)ch[i]);
            if(Max != (int)ch[i]){
                count++;
                break;
            }
        }
        Max=-1;
    }
    return count;
}
};