class Solution {
public:
    vector<int> countPoints(vector<vector<int>>& points, vector<vector<int>>& queries) {
        vector<int> ans;
        int count;
        for(auto query : queries){
            count=0;
            for(auto point : points){
                if( pow((query[0]-point[0]),2) + pow((query[1]-point[1]),2) <= pow(query[2],2) )
                    count++;
            }
            ans.push_back(count);
        }
        return ans;
    }
};