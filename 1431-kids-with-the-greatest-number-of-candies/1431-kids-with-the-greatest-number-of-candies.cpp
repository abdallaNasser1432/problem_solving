class Solution {
public:
    vector<bool> kidsWithCandies(vector<int>& candies, int extraCandies) {
        vector<bool> ans;
        int greatest=0;
        for(int i=0; i<candies.size(); i++){
            greatest=max(greatest,candies[i]);
        }
        for(int i=0; i<candies.size(); i++){
            if(candies[i]+extraCandies>=greatest)
                ans.push_back(true);
            else
                ans.push_back(false);
        }
        return ans;
    }
};