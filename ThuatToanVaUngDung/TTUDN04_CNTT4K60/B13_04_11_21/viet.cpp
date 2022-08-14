//viet
#include<bits/stdc++.h>
using namespace std;
int main()
{
	int test;
	cin>>test;
	while(test--)
	{
		long long b,c,n,M=1e9+7,s[10005];
		cin>>b>>c>>n; 
		s[0]=2; s[1]=-b;
		for(int i=2;i<=n;i++) s[i]=(-b*s[i-1]%M-c*s[i-2]%M)%M;
		cout<<(s[n]+M)%M<<" ";	
	}
}


