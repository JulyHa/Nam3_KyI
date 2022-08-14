//Doi tien quay lui
#include<bits/stdc++.h>
using namespace std;
class money
{
	int n,M,a[1000],res=1e9;
	public:void nhap()
	{
		cin>>n>>M;
		for(int i=1;i<=n;i++) cin>>a[i];
		TRY(0,0,0);
		if(res==1e9) cout<<"Khong doi duoc";
		else cout<<"\nSo to it nhat "<<res;
	}
	private:void TRY(int k,int t,int T)
	{
		if(k==n-1 && (M-T)%a[n]==0) res=min(res,t+(M-T)/a[n]);
		else if(k<n-1) for(int x=0;T+a[k+1]*x<=M && t+x<res;x++) TRY(k+1,t+x,T+a[k+1]*x);
	}
};
int main()
{
	money M; M.nhap();
}


