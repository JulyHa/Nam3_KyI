//bai toan TSP dung next_permutation
#include<bits/stdc++.h>
#include<algorithm>
using namespace std;
int main()
{
//	freopen("g.txt","r",stdin);
	int a[100],n,res=INT_MAX;
	int b[20][20];
	cin>>n;
	for(int i=1;i<=n;i++) 
	{
		a[i]=i;
		for(int j=1;j<=n;j++) cin>>b[i][j];
	}
	a[n+1]=1;
	do
	{
		int t=0;
		for(int i=2;i<=n+1;i++) t+=b[a[i-1]][a[i]];
		if(t<res)res=t;	
	}while(next_permutation(a+2,a+n+1));
	cout<<res;
}


