#include<bits/stdc++.h>
using namespace std;
int a[1006][1006],c[1006][1006],n,m;
int sol(int b)
{
	int res=0;
	for(int i=1;i<=n;i++) c[i][1]=a[i][1]==b; 
	for(int j=1;j<=m;j++) c[1][j]=a[1][j]==b; 
	for(int i=2;i<=n;i++) 
	for(int j=2;j<=m;j++)
	if(a[i][j]!=b) c[i][j]=0;
	else
	{
		int k=min(c[i-1][j],c[i][j-1]);
		if(a[i-k][j-k]==b) k++;
		c[i][j]=k;
		if(res<k) res=k;
	}
	return res;
}
int main()
{
	cin>>n>>m;
	for(int i=1;i<=n;i++) 
	for(int j=1;j<=m;j++) cin>>a[i][j];
	cout<<max(sol(0),sol(1));
}


