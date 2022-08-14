#include<bits/stdc++.h>
using namespace std;
long long n,a[1000005],C[1000005],res=-INT_MAX,L1,L2;
int main()
{
	freopen("a1.in","r",stdin);
	freopen("a1.out","w",stdout);
	deque<int> Q;
	cin>>n>>L1>>L2;
	for(int i=1;i<=n;i++) cin>>a[i];
	for(int i=1;i<=n;i++)
	{
		int k=i-L1;
		if(k>=1) 
		{
			while(Q.size() && C[Q.back()]<C[k]) Q.pop_back();
			Q.push_back(k);
		} 
		while(Q.size() && i-Q.front()>L2) Q.pop_front();
		C[i]=(Q.size()&&C[Q.front()]>0?C[Q.front()]:0)+a[i];
	}
	cout<<*max_element(C+1,C+n+1);
}

