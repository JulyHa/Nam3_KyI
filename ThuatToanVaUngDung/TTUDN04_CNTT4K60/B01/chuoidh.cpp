#include<bits/stdc++.h>
using namespace std;
//Nhap n tim 1/1+1/2+...+1/n=A/B
int main()
{
	int n;
	cin>>n;
	long long A=0,B=1,C,i;
	for(i=2;i<=n;i++) B*=i/__gcd(B,i);
	for(int i=1;i<=n;i++) A+=B/i;
	C=__gcd(A,B);
	cout<<A<<"/"<<B<<"\n";
}


