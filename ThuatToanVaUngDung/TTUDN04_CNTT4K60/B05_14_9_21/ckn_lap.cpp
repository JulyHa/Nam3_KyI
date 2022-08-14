#include<bits/stdc++.h>
using namespace std;

long long C(int k,int n)
{
	long long res=1;					//2
	if(k<n-k) k=n-k;				
	for(int i=k+1;i<=n;i++) res*=i;     //3 + (n-(k+1)+1)*4 + 1
	for(int i=1;i<=n-k;i++) res/=i;     //2 +  (n-k)*5 + 2
	return res; 						//1
}
//Khong gian: sizeof(k)+sizeof(n)+sizeof(i)*2+sizeof(res) = O(1);
//Thoi gian   Omega(1) = T(n)= 11 + (n-k)*9   = O(n)
long long T(int k,int n)
{
	int C[n+1]={1,1};				//1+1+ 2 +2  
	for(int i=2;i<=n;i++)			
	{
		C[i]=1;
		for(int j=i-1;j>0;j--) C[j]+=C[j-1];
	}
	return C[k];
}
//Khong gian K(n)= sizeof(k)+sizeof(n)+sizeof(i)+sizeof(j) +sizeof(C) = O(n)
//Thoi gian T(n) = O(n^2)
int main()
{
	for(int i=0;i<=37;i++) cout<<T(i,37)<<" ";
}


