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
        else
            round+=it.second/3 +1;
    }
    return round;
}
};