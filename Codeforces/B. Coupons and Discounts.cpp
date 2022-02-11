// https://codeforces.com/contest/731/problem/B
#include<bits/stdc++.h>
#define ll long long
using namespace std;
void fast(){
    ios::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
#ifndef ONLINE_JUDGE
    freopen("Input.txt","r",stdin), freopen("out.txt","w",stdout);
#endif
}
int main(){
    fast();
    int n; cin>>n;
    vector<int>a(n);
    for(int i=0;i<n;i++){
        cin >> a[i];
    }
 
    for(int i=0;i<n;i++)
    {
        if(a[i]<0)
        {
            cout << "NO";
            return 0;
        }
        if(a[i]%2==1)
        {
            if(i==n-1)
            {
                cout << "NO";
                return 0;
            }
            a[i+1]--;
        }
    }
    cout << "YES";
 
    return 0;
}
