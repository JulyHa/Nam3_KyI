#include<bits/stdc++.h>
#define ll long long
#define v first
#define w second
using namespace std;
class balo{
	int n, M, res = 0, t[105]={}, test;
	pair<int,int> A[105];
	public :void sol(){
		cin>>n;
		for(int i=1; i<=n; i++) cin>>A[i].w>>A[i].v;
		sort(A+1, A+n+1, greater<pair<int,int>>());
		for(int i=n; i>0; i--) t[i] = A[i].v + t[i+1];
		cin>>test;
		while(test--){
		 	res=0;
			cin>>M;
			TRY(1,0,0);
			cout<<res<<"\n";
		}
	}
	void TRY(int k, int W, int V){
		if(k<=n) 
		{	res = max(res,V);
			if(A[k].w+W <= M && t[k]+V+A[k].v > res) TRY(k+1, W+A[k].w, V+A[k].v);
		
			if(t[k+1]+V > res) TRY(k+1, W, V);
		}
	}
};
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	balo b;
	b.sol();
}


