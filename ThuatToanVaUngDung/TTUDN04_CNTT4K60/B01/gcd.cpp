#include<bits/stdc++.h>
using namespace std;
int gcd(int a,int b)
{
	while(b)
	{
		r=a%b;
		a=b;
		b=r;
	}	
}
int main()
{
	int a,b;
	cin>>a>>b;
	cout<<a+b-gcd(a,b);
}


