class Solution {
public:
    vector<int> twoSum(vector<int>& numbers, int target) {
        vector<int> ans;
        int size=numbers.size();
        for(int i=0; i<size-1; i++){
            if(i>0 and numbers[i]==numbers[i-1])
                continue;
            for(int j=i+1; j<size; j++){
                if(numbers[i]+numbers[j]==target){
                    ans.push_back(i+1);
                    ans.push_back(j+1);
                    break;
                }
            }
        }
        return ans;
    }
};