//xau con chung dai nhat
#include<bits/stdc++.h>
using namespace std;
class XCC
{
	int n,m,C[105][105]={};
	string x,y;
	void dp()  //dinamic programming
	{
		for(int i=1;i<=n;i++)
		for(int j=1;j<=m;j++)
		if(x[i]==y[j]) C[i][j]=C[i-1][j-1]+1;
		else C[i][j]=max(C[i-1][j],C[i][j-1]);
	}
	void trace(int u,int v)
	{
		if(C[u][v])
		{
			while(C[u][v]==C[u-1][v])u--;
			while(C[u][v]==C[u][v-1])v--;
			trace(u-1,v-1);
			cout<<x[u];
		}
	}
	public:void sol()
	{
		cin>>x>>y; n=x.size(),m=y.size();
		x="$"+x;
		y="$"+y;
		dp();
		cout<<"\nXau con chung dai nhat co do dai "<<C[n][m]<<"\n";
		trace(n,m);
	}
};
int main(){XCC z; z.sol();}


