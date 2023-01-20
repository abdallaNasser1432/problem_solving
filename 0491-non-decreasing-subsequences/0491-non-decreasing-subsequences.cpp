class Solution {
public:
set<vector<int>>s;
void subsequnce(vector<int>& nums, vector<int>&ds , int i , int n)
{
    if( i == n )
    {
        if( ds.size()>1)
            s.insert( ds);
    
        return ;

    }
    ds.push_back(nums[i]);
    subsequnce(nums,ds, i+1, n);
    ds.pop_back();
    subsequnce( nums , ds, i+1, n);

}

    vector<vector<int>> findSubsequences(vector<int>& nums) {
        
        vector<vector<int>> ans;
       
        int n = nums.size();
        vector<int> ds;
        subsequnce(nums, ds, 0 , n);

        for( auto x : s)
        {
            vector<int> temp = x; 
            sort( temp.begin(), temp.end());
            if( temp ==x )ans.push_back(x);
          
        }
        return ans;
    }

};