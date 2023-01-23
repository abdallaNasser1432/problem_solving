class Solution {
public:
    int findJudge(int n, vector<vector<int>>& trust) {
        set<int>people;
        map<int,int>judge;
        if(trust.size()<1 and n==1)
            return n;
        for(auto i : trust){
            people.insert(i[0]);
            judge[i[1]]++;
        }
        if(people.size()!= n-1)
        return -1;
    for (auto it=judge.begin(); it!=judge.end(); ++it) {
        if (people.find(it->first) == people.end() and it->second == people.size() and people.size()!=0)
            return it->first;
    }
    return -1;
    }
};