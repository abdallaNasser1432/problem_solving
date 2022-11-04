class Solution {
public:
   string reverseVowels(string s) {
    vector<int> vowels;
    for (int i = 0; i < s.size(); ++i) {
        if (s[i] == 'a' or s[i]== 'u' or s[i]=='i' or s[i]=='o' or s[i]=='e'
            or s[i] == 'A' or s[i]== 'U' or s[i]=='I' or s[i]=='O' or s[i]=='E')
            vowels.push_back(i);
    }
    if (!vowels.empty()) {
        int l =0, r =vowels.size()-1;
        while (l<r){
            swap(s[vowels[l]],s[vowels[r]]);
            l++;r--;
        }
    }
    return s;
}
};