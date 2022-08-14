#include<bits/stdc++.h>
using namespace std;
long long M=1e9+7;

long long cp(int n)
{
	long long m=n+1,k=n+2;
	if(n%3==0) n/=3;
	if(m%3==0) m/=3;
	if(k%3==0) k/=3;
	if(n%2==0) n/=2; else m/=2;
	n%=M; m%=M; k%=M;
	return n*m%M*k%M;
}

int main()
{
	cout<<cp(1000);
}


