class Solution {
public:
   int singleNonDuplicate(vector<int>& nums) {
    int left =0; int right =nums.size()-1;
    while(left < right ){// 1 1 2 3 3
        if(nums[left] != nums[left+1])return nums[left];
        if(nums[right] != nums[right-1])return nums[right];
        left+=2; right-=2;
    }
    return nums[left];
}
};