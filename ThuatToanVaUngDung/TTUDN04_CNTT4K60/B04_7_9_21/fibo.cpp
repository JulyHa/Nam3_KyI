#include<bits/stdc++.h>
using namespace std;
int main()
{
	int n;											//1
	cin>>n;											//1			
	long long F[n+1]={0,1};							//1+1+2+2;
	int i=2;										//2
	for(;i<=n;i++) F[i]=F[i-1]+F[i-2];				//(n-1)9 + 1
	cout<<F[n];										//2
}
//Do phuc tap ko gian K(n) = sizeof(n)+sizeof(F)+sizeof(i) = 4+(n+1)*16+4
//Do phuc tap thoi gian T(n)= 13+9(n-1)=9n+2;

