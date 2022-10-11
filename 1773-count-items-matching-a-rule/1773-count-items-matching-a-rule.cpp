class Solution {
public:
    int countMatches(vector<vector<string>>& items, string ruleKey, string ruleValue) {
    int count=0;int target;
    if (ruleKey=="type")target=0; 
    else if (ruleKey=="color")target=1;
    else target=2;
    for (int i = 0; i <items.size() ; ++i)
        if (items[i][target]==ruleValue)
            count++;
    return count;

}
};