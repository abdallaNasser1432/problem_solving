class Solution {
public:

vector<int> findErrorNums(vector<int>& nums) {
    int missing,dup;
    int intialSum= accumulate(nums.begin(),nums.end(),0);
    set<int> s;
    for(auto &i: nums)
        s.insert(i);
    int sumWithoutDup=accumulate(s.begin(), s.end(), 0);
    dup=intialSum-sumWithoutDup;
    int n = nums.size();
    missing = n * (n+1)/2 - sumWithoutDup;
    return {dup,missing};

}
};