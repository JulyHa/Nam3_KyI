#include<bits/stdc++.h>

int nhan(int a,int b) {return a*b;}
using namespace std;
int main()
{
	int a[]={24,72,48,36},n=sizeof(a)/sizeof(int);
	int b[n];
	partial_sum(a,a+n,b,__gcd<int>);
	for(auto x:b) cout<<x<<" "; cout<<"\n";
}


