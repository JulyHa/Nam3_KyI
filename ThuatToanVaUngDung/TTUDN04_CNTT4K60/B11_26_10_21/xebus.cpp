//xe bus cho toi da q khac, con n nguoi dung o vi 1..n xuong o vi tri tuong ung n+1,n+2...2n
#include<bits/stdc++.h>
using namespace std;
class bus
{
	int n,Q,d[205]={},x[205],dem=0;
	void TRY(int k,int q) //gia su da co x1...x[k-1]
	{
		if(k>2*n) 
		{
			cout<<"\n"<<setw(5)<<++dem<<" : ";
			for(int i=1;i<k;i++) cout<<(x[i]>n?-x[i]:x[i])<<" ";
			return;
		} 
		for(int t=Q==q?n+1:1;t<=2*n;t++)
		if(d[t]==0 && (q>0 || t<=n))
		{
			d[t]=1; if(t<=n) d[n+t]=0;
			x[k]=t;
			TRY(k+1,q+(t>n?-1:1));
			d[t]=0; if(t<=n) d[n+t]=1;
		}
	}
	public: void sol()
	{
		cin>>n>>Q;
		for(int i=n+1;i<=2*n;i++) d[i]=1;
		TRY(1,0);
	}
};
int main()
{
	bus B; B.sol();
}


