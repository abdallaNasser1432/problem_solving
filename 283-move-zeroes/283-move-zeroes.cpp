class Solution {
public:
    void moveZeroes(vector<int>& nums) {
        int size=nums.size();
        int start=0,end=0;
        for(int i=0; i<size; i++){
            if(nums[i]==0)
                end++;
            else{
                swap(nums[i],nums[start]);
                start++;
                end++;
            }
        }
    }
};