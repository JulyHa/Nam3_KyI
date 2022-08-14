//Nguoi di du lich_ Sinh hoan vi
#include<bits/stdc++.h>
#define ll long long
using namespace std;
class graph
{
	int n, a[20][20], d[20] = {0,1}, res = INT_MAX, c_min=1e9;
	
	public : void sol()
	{
		cin>>n;
		for(int i=1; i<=n; i++)
		{
			for(int j=1; j<=n; j++){
				cin >> a[i][j];
				c_min=min(c_min, a[i][j]);
			}
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
				if((T + a[x][t])+c_min*(n-k) < res)TRY(k+1,t,T + a[x][t]);
				d[t] = 0;
			}
		}
	}
};
int main()
{
	graph G; G.sol();
}
