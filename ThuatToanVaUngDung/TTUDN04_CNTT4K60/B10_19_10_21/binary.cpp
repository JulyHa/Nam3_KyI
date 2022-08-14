#include<bits/stdc++.h>
using namespace std;

//void TRY(int *x,int k,int n)  //gia su da di duoc x1...xk
//{
//	if(k==n) {for(int i=1;i<=n;i++) cout<<x[i]; cout<<"\n";}
//	else
//		for(int t=0;t<=1;t++) 
//		{
//			x[k+1]=t;
//			TRY(x,k+1,n);
//		}
//}

//void TRY(int *x,int k,int n)  //gia su da di duoc x1...x[k-1]
//{
//	if(k>n) {for(int i=1;i<k;i++) cout<<x[i]; cout<<"\n";}
//	else for(x[k]=0;x[k]<=1;x[k]++) TRY(x,k+1,n);
//}
//void TRY(char *x,int k,int n)  //gia su da di duoc x0,x1...x[k-1] ->co k phan tu
//{
//	if(k==n) cout<<x<<"\n";
//	else for(x[k]='0';x[k]<='1';x[k]++) TRY(x,k+1,n);
//}

void TRY(string x,int n)
{
	if(x.size()==n) {cout<<x<<"\n"; return;}
	TRY(x+"0",n);
	TRY(x+"1",n);
}
int main()
{
//	int n; cin>>n;
//	char x[100]={};
//	TRY(x,0,n);
	TRY("",3);
}


