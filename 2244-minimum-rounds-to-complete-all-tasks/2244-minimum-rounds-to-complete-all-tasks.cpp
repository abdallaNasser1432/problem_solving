class Solution {
public:
    int minimumRounds(vector<int>& tasks) {
    map<int,int>m;
    for(auto i : tasks)
        m[i]++;
    int round=0;
    for (auto & it : m) {
        if (it.second == 1)
            return -1;
        else if (it.second % 3== 0)
             round+=it.second/3;
        else if(it.second % 3 == 2 and it.second!=2)
            round+=(it.second -2)/3 +1;
        else if(it.second % 3 == 1)
            round+=(it.second -4)/3 +2;
        else
            round++;
    }
    return round;
}
};