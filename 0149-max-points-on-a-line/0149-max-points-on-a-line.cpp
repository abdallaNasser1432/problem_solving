class Solution {
public:
int maxPoints(vector<vector<int>>& points) {
    int num=1;
    map<double,int>m;
    for (int i = 0; i <points.size()-1 ; ++i) {
        for (int j = i+1; j <points.size() ; ++j) {
            double slope = (double)(points[j][1]-points[i][1])/(double)(points[j][0]-points[i][0]);
            if(points[j][1]-points[i][1]<0 &&(points[j][0]-points[i][0])==0 ) 
                m[abs(slope)]++; 
            else
            m[slope]++;
        }
    int maxx=0;
    for (auto it:m)
        maxx= max(maxx,it.second+1);
        num=max(maxx,num);
        m.clear();
        }
    return  num;

}
};