#include<bits/stdc++.h>
using namespace std;
class money
{
	int n,M,a[1000],C[100][100]={};
	public:
	void dp() //dynamic programming
	{
		for(int j=1;j<=M;j++) C[0][j]=1e9;
		for(int i=1;i<=n;i++)
		for(int j=0;j<=M;j++)
		if(j<a[i]) C[i][j]=C[i-1][j];
		else C[i][j]=min(C[i-1][j],1+C[i][j-a[i]]);
	}
	string trace(int n,int M)
	{
		if(C[n][M]==0) return "";
		while(C[n][M]==C[n-1][M]) n--;
		return trace(n,M-a[n])+"+"+to_string(a[n]);
	}
	void sol()
	{
		cin>>n>>M;
		for(int i=1;i<=n;i++) cin>>a[i];
		dp();
		if(C[n][M]==1e9) cout<<"Khong doi duoc";
		else 
		{
			cout<<"\nSo to it nhat "<<C[n][M]<<"\n";
			string res=trace(n,M);
			cout<<res.substr(1);
		}
	}
};
int main()
{
	money M; M.sol();
}


