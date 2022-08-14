#include<bits/stdc++.h>
#define ll long long
#define v first
#define w second
using namespace std;
class balo{
public : 
	void sol(){
		int n,f[10004]={}, test, fm=0, x, y;
		cin>>n;
		vector<pair<int, int>>A;		
		for(int i=0; i<n; i++){cin>>x>>y;A.push_back({x,y});}
		cin>>test;
		for(int i=1; i<=test; i++)cin>>f[i], fm=max(f[i],fm);
		int i=1, M[n+5][fm+5]={};
		for(auto x : A){
			for(int j=1; j<= fm; j++){
				if(x.v <= j){
					M[i][j] = max(M[i-1][j], M[i-1][j-x.v]+x.w);
				} 
				else M[i][j] = M[i-1][j];
			}
			i++;
		}
		n = A.size();
		for(int i=1; i<=test; i++) cout<<M[n][f[i]]<<"\n";
	}
};
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	balo b;
	b.sol();
}


