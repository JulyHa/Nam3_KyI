#include<bits/stdc++.h>
using namespace std;
int main()
{
	long long n,M,res=0;
	cin>>n>>M;
	long long a[n];
	for(auto &x:a) cin>>x;				//nhap menh gia
	sort(a,a+n,greater<long long> ()); //sap xep giam dan
	for(auto x:a)
	{
		res+=M/x;
		M%=x;
	}
	if(M==0) cout<<"so to it nhat "<<res;
	else cout<<"\nKhong doi duoc"; 
}


