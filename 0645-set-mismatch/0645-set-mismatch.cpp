class Solution {
public:

vector<int> findErrorNums(vector<int>& nums) {
    int missing=0,dup=0;
    map<int,int>m;
    for (int i = 0; i < nums.size(); ++i) {
        m[i+1];
        m[nums[i]]++;
    }
    for (auto it=m.begin();it!=m.end() ; ++it) {
        if(it->second==2)dup=it->first;
        else if (it->second==0)missing=it->first;
        if (dup!=0 and missing !=0)
            break;
    }
    return {dup,missing};

}
};