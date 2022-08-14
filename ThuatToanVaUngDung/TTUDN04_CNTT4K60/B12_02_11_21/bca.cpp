#include<bits/stdc++.h>
using namespace std;
class BCA
{
	int m,n,C[35][35]={},X[35],res=35;
	map<int, set<int>> p;
	map<int, set<int>> A; //Mon k do nhung ai day
	public: void sol()
	{
		int k,u,v,w;
		cin>>m>>n;
		for(int i=1;i<=m;i++)
		{
			cin>>k;
			while(k--) {cin>>u;	A[u].insert(i);}
		}
		cin>>k;
		while(k--)
		{
			cin>>v>>w;
			C[w][v]=C[v][w]=1;
		}
		TRY(1);
		cout<<res;
	}
	void TRY(int k) //da co x1..x[k-1]
	{
		if (k>n)
		{
			int kq=0;
			for(auto z:p) if(kq<z.second.size()) kq=z.second.size();
			if(res>kq) res=kq;
			return;
		}
		for(int t:A[k])
		if(p[t].size()<res-1)
		{
			int ok=1;
			for(auto z:p[t]) if(C[z][k]) ok=0; 
			if(ok)
			{
				X[k]=t;
				p[t].insert(k);
				TRY(k+1);
				p[t].erase(k);
			}
		}
	}
};
int main()
{
//	freopen("bca.txt","r",stdin);
	BCA B;
	B.sol();
}


