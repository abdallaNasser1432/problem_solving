#include <bits/stdc++.h>
using namespace std;
typedef long long ll;
 
void fast(){
    ios::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
#ifndef ONLINE_JUDGE
    freopen("Input.txt","r",stdin), freopen("Out.txt","w",stdout);
#endif
}
int main()
{
    fast();
    int t;
    cin>>t;
    while (t--){
        string a,s;bool flag= false;
        cin>>a>>s;
        int count= size(s)- size(a);
        if(count<0){
            cout<<-1<<"\n";
            continue;
        }
        vector<int>soul;
        int temp1,temp2;
        int j = size(s)-1;
        for (int i = size(a)-1; i >=0 ; --i) {
            temp1=a[i]-'0';temp2=s[j]-'0';
            if((temp2-temp1>=0)&&(count>=0)){
                soul.push_back(temp2-temp1);
                j--;
                continue;
            }
            else{
                if(count<0){
                    cout<<-1<<"\n";
                    flag= true;
                    break;
                }
                j--;
                temp2+=(s[j]-'0')*10;
                if(temp2-temp1<=10&&temp2-temp1>=0){
                    soul.push_back(temp2-temp1);
                    j--;
                    count--;
                    continue;
                }
                else{
                        cout<<-1<<"\n";
                        flag= true;
                        break;
                    }
            }
        }
        if(flag== false && count > 0){
            for (j; j >=0 ; --j){
                temp2=s[j]-'0';
                soul.push_back(temp2);
            }
        }
        if(flag== false){
            for (auto it=soul.rbegin(); it !=soul.rend() ; ++it){
                if(flag== false&&*it==0)
                    continue;
                cout<<*it;
                flag= true;
            }
            if(flag== false)
                cout<<0;
            cout<<"\n";
        }
    }
}
