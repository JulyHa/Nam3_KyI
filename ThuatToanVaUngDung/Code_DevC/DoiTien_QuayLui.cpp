//Doi tien quay lui
#include<bits/stdc++.h>
using namespace std;
class money
{
	int n,M,a[1000],res=1e9,pa[1000],x[1000];
	public:void nhap()
	{
		cin>>n>>M;
		for(int i=1;i<=n;i++) cin>>a[i];
		TRY(0,0,0);
		if(res==1e9) cout<<"Khong doi duoc";
		else 
		{
			cout<<"\nSo to it nhat "<<res<<"\n";
			for(int i=1;i<n;i++) cout<<pa[i]<<"*"<<a[i]<<"+";
			 cout<<pa[n]<<"*"<<a[n];
		}
	}
	private:void TRY(int k,int t,int T)		// k la so loai menh gia // t la tong so to // T so tien da doi duoc
	{
		if(k==n)
		{
			if((M-T)%a[n]==0)
			{
				x[n]=(M-T)/a[n];
				res=min(res,t+x[n]);
				for(int i=1;i<=n;i++) pa[i]=x[i];
			}
			return;
		}
		for(x[k]=0;T+a[k]*x[k]<=M && t+x[k]<res;x[k]++)
			TRY(k+1,t+x[k],T+a[k]*x[k]);
	}
};
int main()
{
	money M; M.nhap();
}

