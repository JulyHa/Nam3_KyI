#include<bits/stdc++.h>
using namespace std;
int main()
{
	int a[105][105],c[105][105]={},n,res=-INT_MAX;
	cin>>n;
	for(int i=1;i<=n;i++) 
	for(int j=1;j<=n;j++) cin>>a[i][j];
	for(int i=1;i<=n;i++) 
	for(int j=1;j<=n;j++) c[i][j]=c[i-1][j]+c[i][j-1]-c[i-1][j-1]+a[i][j];
	
	for(int i=1;i<=n;i++) 
	for(int j=1;j<=n;j++) 
	{
		for(int u=1;u<=i;u++)
		for(int v=1;v<=j;v++)
		{
			int z=c[i][j]-c[i-u][j]-c[i][j-v]+c[i-u][j-v];
			if(z>res) res=z;
		}
	}
	cout<<res;
}


