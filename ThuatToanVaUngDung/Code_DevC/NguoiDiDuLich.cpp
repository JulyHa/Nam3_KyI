//TPS bang quay lui vet can
#include<bits/stdc++.h>
using namespace std;

class graph
{
	int n, a[20][20], d[20] = {0,1}, res = INT_MAX;
	
	public : void sol()
	{
		cin >> n;
		for(int i=1; i<=n; i++)
		{
			for(int j=1; j<=n; j++)
				cin >> a[i][j];
		}
		TRY(1, 1, 0);
		cout<< res;
	}
	private : void TRY(int k,int x,int T)
	{
		if(k == n)	res = min(res, T+a[x][1]);
		else
		{
			for(int t=2; t <= n; t++)
			if(d[t] == 0)
			{
				d[t] = 1;
				//TRY(k+1,t,T + a[x][t]);
				if((T + a[x][t]) < res)TRY(k+1,t,T + a[x][t]);
				d[t] = 0;
			}
		}
	}
};
int main()
{
//	graph G; G.sol();
	int a = 0; 
	if(a) cout<<"0";
	if(a ==0) cout<<"1"; 
}
