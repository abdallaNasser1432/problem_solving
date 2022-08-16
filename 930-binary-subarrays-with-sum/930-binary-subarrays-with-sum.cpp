class Solution {
public:
    int numSubarraysWithSum(vector<int>& A, int s) {
        int cumsum=0,count=0;
        unordered_map<int,int> map;
        for(int i=0;i<A.size();i++){
            cumsum+=A[i];
            if(cumsum==s) count++;
            if(map[cumsum-s]) count+=map[cumsum-s];
            map[cumsum]++;
        
        }
        return count;
    }
};