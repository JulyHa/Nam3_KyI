//TSP bang quay lui
#include<bits/stdc++.h>
using namespace std;
class graph
{
	int n,a[20][20],d[20]={0,1},res=INT_MAX,cmin=1e9;
	public: void sol()
	{
		cin>>n;
		for(int i=1;i<=n;i++) 
		for(int j=1;j<=n;j++) 
		{
			cin>>a[i][j];
			if(a[i][j]<cmin) cmin=a[i][j];
		}
		TRY(1,1,0);
		cout<<res;
	}
	private:void TRY(int k,int x,int T)
	{
		if(k==n) res=min(res,T+a[x][1]);
		else
		{
			for(int t=2;t<=n;t++)
			if(d[t]==0 and T+a[x][t]+cmin*(n-k)<res)
			{
				d[t]=1;
				TRY(k+1,t,T+a[x][t]);
				d[t]=0;
			}
		}
	}
};
int main(){graph G; G.sol();}


