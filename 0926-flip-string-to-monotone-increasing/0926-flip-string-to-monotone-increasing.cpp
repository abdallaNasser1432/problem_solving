class Solution {
public:
    int minFlipsMonoIncr(string s) {
        int zeros=0,flips=0;
        for(auto i:s){
            if(i=='1') zeros++;
            else flips++;
            flips=min(flips,zeros);
        }
        return flips;
    }
};