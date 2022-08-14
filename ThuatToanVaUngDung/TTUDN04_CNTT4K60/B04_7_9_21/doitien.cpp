#include<bits/stdc++.h>
using namespace std;
typedef pair<int,int> pii;
struct ss
{
	bool operator()(pii u,pii v)
	{
		if(u.second==v.second) return u.first<v.first;
		return u.second>v.second;
	}	
};

class money
{
	int n,M,a[100];
	map<int,int> T;  //first - so tien, second - soto
	int BFS()
	{
		priority_queue < pii,vector<pii>, ss> Q;
		Q.push({0,0}); T[0]=0;
		while(Q.size())
		{
			pii u=Q.top(); Q.pop();
			for(int i=1;i<=n;i++)
			if(u.first+a[i]<=M && T.find(u.first+a[i])==T.end())
			{
				T[u.first+a[i]]=u.second+1;
				Q.push({u.first+a[i],u.second+1});
			}
			if(T.find(M)!=T.end()) return T[M];
		}
		return -1;
	}
	public: void sol()
	{
		cout<<"Nhap n = "; cin>>n; for(int i=1;i<=n;i++) cin>>a[i];
		cout<<"M = "; cin>>M;
		//sort(a+1,a+n+1,greater<int>());
		int kq=BFS();
		if(kq==-1) cout<<"Khong doi duoc";
		else cout<<"\nSo to "<<kq;
	}
};
int main()
{
	money M; M.sol();
}


