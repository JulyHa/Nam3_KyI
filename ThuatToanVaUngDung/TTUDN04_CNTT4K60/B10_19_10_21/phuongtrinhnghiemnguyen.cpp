//Phuong trinh x1+x2+...+xn = M in ra cac nghiem nguyen khong am
#include<bits/stdc++.h>
using namespace std;
int d=0;
//void TRY(int *x,int k,int T,int n,int M) //da co x1+...+xk = T
//{
//	if(k==n-1) {for(int i=1;i<=k;i++) cout<<x[i]<<"+"; cout<<M-T<<"\n"; d++; return;}
//	for(int t=0;t+T<=M;t++)
//	{
//		x[k+1]=t;
//		TRY(x,k+1,T+t,n,M);
//	}
//}
void TRY(int *x,int k,int T,int n,int M) //da co x1+...+xk = M-T
{
	if(k==n-1) {for(int i=1;i<=k;i++) cout<<x[i]<<"+"; cout<<T<<"\n"; d++; return;}
	for(int t=0;t<=T;t++)
	{
		x[k+1]=t;
		TRY(x,k+1,T-t,n,M);
	}
}
int main()
{
	int x[100],n,M;
	cin>>n>>M;
	TRY(x,0,M,n,M);
	cout<<"\nSo nghiem "<<d;
}


