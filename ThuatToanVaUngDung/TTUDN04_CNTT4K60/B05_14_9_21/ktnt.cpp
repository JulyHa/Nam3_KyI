#include<bits/stdc++.h>
using namespace std;


bool kt(long long n)
{
	if(n==2) return 1;
	if(n<2|| n%2==0) return 0;
	for(long long i=3;i*i<=n;i+=2) if(n%i==0) return 0;
	return 1;
}
int main()
{
	int n;
	cin>>n;
	for(int i=1;i<=n;i++) if(kt(i)) cout<<i<<" ";
}
//Thoi gian T(n) = Omega(1)
//Thoi gian T(n) = O(sqrt(n))  
//Khong danh gia duoc tiem can chat



