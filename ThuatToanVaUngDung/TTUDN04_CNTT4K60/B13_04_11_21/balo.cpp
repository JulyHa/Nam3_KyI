#include<bits/stdc++.h>
using namespace std;
#define v first
#define w second
class balo
{
	int n,test,M,res=0,t[105]={};
	map <int,int> Dic;
	pair<int,int> A[105];
	public:void sol()
	{
		cin>>n;
		for(int i=1;i<=n;i++) cin>>A[i].w>>A[i].v;  //second-w, first-v
		sort(A+1,A+n+1,greater<pair<int,int>>()); //sap xep giam dan first = v
		for(int i=n;i>=1;i--) t[i]=A[i].v+t[i+1];
		cin>>test;
		while(test--)
		{
			cin>>M; 
			if(Dic.find(M)!=Dic.end()) res=Dic[M];
			else
			{
				res=0;
				TRY(1,0,0);
				Dic[M]=res;
			}
			cout<<res<<"\n";
		}
	}
	void TRY(int k,int W,int V)
	{
		if(k<=n) 
		{
			res=max(res,V);
			if(A[k].w+W<=M && t[k+1]+V+A[k].v>res)  TRY(k+1,W+A[k].w,V+A[k].v);
			if(t[k+1]+V>res) TRY(k+1,W,V);  //bo qua vat k
		}
	}
	
};
int main()
{
	ios_base::sync_with_stdio(false);
    cin.tie(NULL);cout.tie(NULL);
	balo B; B.sol();
}


