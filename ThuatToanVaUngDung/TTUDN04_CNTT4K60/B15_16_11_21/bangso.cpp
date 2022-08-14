#include<bits/stdc++.h>
using namespace std;
int a[1001][1001];
void trace(int u,int v)
{
	if(u==0 || v==0) return;
	if(u==1 or a[u][v-1]>a[u-1][v]) trace(u,v-1); 
	else trace(u-1,v); 
	cout<<"("<<u<<","<<v<<")";
}
int main()
{
	int n,m;
	cin>>n>>m;
	for(int i=1;i<=n;i++)
	for(int j=1;j<=m;j++) cin>>a[i][j];
	for(int i=2;i<=n;i++) a[i][1]+=a[i-1][1];
	for(int j=2;j<=m;j++) a[1][j]+=a[1][j-1];
	for(int i=2;i<=n;i++) 
	for(int j=2;j<=m;j++) a[i][j]+=max(a[i-1][j],a[i][j-1]);
	cout<<a[n][m]<<"\n";
	trace(n,m);
}


