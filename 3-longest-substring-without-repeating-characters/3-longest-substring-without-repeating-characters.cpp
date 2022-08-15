class Solution {
public:
    bool  isExisting(string s, int start, int end, char c){
        for(int i=start; i<=end; i++){
            if(s[i]==c)
                return true;
        }
        return false;
    }
    int lengthOfLongestSubstring(string s) {
        if(s.size()==1)
            return 1;
        int start=0,end=0;
        int ans=0;
        for(int i=1; i<s.size(); i++){
            while(isExisting(s,start,end,s[i])){
                start++;
            }
            end=i;
            ans=max(ans,end-start+1);
        }
        return ans;
    }
};