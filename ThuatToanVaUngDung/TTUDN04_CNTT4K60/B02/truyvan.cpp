#include<bits/stdc++.h>
#include<algorithm>
using namespace std;
int main()
{
	int n,q;
	scanf("%d%d",&n,&q);
	long long a[n+5]={};
	for(int i=1;i<=n;i++)
	{
		scanf("%lld",&a[i]); //a[i]+=a[i-1];
	}
	partial_sum(a+1,a+n+1,a+1);
	while(q--)
	{
		int L,R;
		scanf("%d%d",&L,&R);
		printf("%lld\n", a[R]-a[L-1]);
	}
}


