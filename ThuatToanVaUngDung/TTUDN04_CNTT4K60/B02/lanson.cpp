//lanson
#include<bits/stdc++.h>
using namespace std;
int main()
{
	int n,m,k,L,R,res=0,a[1000006]={};
	cin>>n>>m>>k;
	while(n--)
	{
		cin>>L>>R;
		a[L]++;
		a[R]--;
	}
	partial_sum(a,a+m+1,a);
	for(int i=1;i<=m;i++) res+=a[i]>=k;
	cout<<res;
}


