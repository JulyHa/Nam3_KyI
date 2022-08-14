#include<bits/stdc++.h>
using namespace std;
long long M=1e9+7;
long long chipheo()
{
	long long n;
	cin>>n;
	n=n%M;
	return n*(n+1)%M*(n+2)%M*166666668%M;
}
int main()
{
	int t;
	cin>>t;
	while(t--)	cout<<chipheo();
}


