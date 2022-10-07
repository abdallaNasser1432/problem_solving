#include <unordered_map>

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        std::unordered_map<int, int> balance;
        
        int i;
        for (i = 0; i < nums.size(); ++i) {
            if (balance.find(nums[i]) != balance.end())
                break;
            
            balance.insert_or_assign(target - nums[i], i);
        }
        
        return {balance[nums[i]], i};
    }
};