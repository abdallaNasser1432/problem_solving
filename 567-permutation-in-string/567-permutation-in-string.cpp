class Solution {
public:
    bool areVectorsEqual(vector<int> v1,vector<int> v2){
        for(int i=0; i<26; i++){
            if(v1[i] != v2[i])
                return false;
        }
        return true;
    }
    bool checkInclusion(string s1, string s2) {
        if(s1.size()>s2.size())
            return false;
        vector<int> s1Freqs(26,0);
        for(char c : s1)
            s1Freqs[c-'a']++;
        vector<int> s2Freqs(26,0);
        int i=0,j=0;
        while(j<s2.size()){
            s2Freqs[s2[j]-'a']++;
            if((j-i+1)==s1.size()){
                if(areVectorsEqual(s1Freqs,s2Freqs))
                    return true;
            }
            if((j-i+1)<s1.size())
                j++;
            else{
                s2Freqs[s2[i]-'a']--;
                i++;
                j++;
            }
        }
     return false;
    }
};