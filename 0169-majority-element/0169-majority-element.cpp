class Solution {
public:
    int majorityElement(vector<int>& nums) {
    map<int,int> freq ; int majority =0 ; int frequancy =0;
    for (int i = 0; i < nums.size(); ++i)
        freq[nums[i]]++;
    for (auto it =freq.begin()  ; it != freq.end() ; ++it) {
        if (it->second>frequancy){
            majority=it->first;
            frequancy =it->second;
        }
    }
    return majority;
}
};