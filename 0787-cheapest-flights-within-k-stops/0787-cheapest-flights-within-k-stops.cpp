class Solution {
public:
    int findCheapestPrice(int n, vector<vector<int>>& flights, int src, int dst, int K)
    {
        const int INF = 1e9;
        K++;
        vector<vector<int>> ans(n, vector<int>(K+1));
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j <= K; j++)
            {
                ans[i][j] = INF;
            }
        }
        ans[src][0] = 0;
        for(int i = 1; i <= K; i++)
        {
            for(int j = 0; j < n; j++)  
                ans[j][i] = ans[j][i-1];
            for(const vector<int>& f: flights)
            {
                ans[f[1]][i] = min(ans[f[1]][i], ans[f[0]][i-1] + f[2]);
            }
        }
        if(ans[dst][K] == INF) return -1;
        return ans[dst][K];
    }
};