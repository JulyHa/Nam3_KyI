//sang so nguyen to
#include<bits/stdc++.h>
using namespace std;

void sang(long long n,vector<long long> &P)
{
	vector<bool> S(n+1,true);
	for(long long i=2;i<=n;i++)
	if(S[i])
	{
		//cout<<i<<" ";
		P.push_back(i);
		for(long long j=i*i;j<=n;j+=i) S[j]=false;
	}
}
int main()
{
	vector<long long> P;
	sang(100000,P);
	for(auto x:P) cout<<x<<" ";
}


