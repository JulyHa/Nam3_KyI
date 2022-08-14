#include<bits/stdc++.h>
using namespace std;
class mecung
{
	int a[105][105],n,m,sx,sy,fx,fy;
	public:void sol()
	{
		cin>>n>>m;
		for(int i=1;i<=n;i++)	
		for(int j=1;j<=m;j++) cin>>a[i][j];
		for(int i=0;i<=n+1;i++) a[i][0]=a[i][m+1]=1;
		for(int j=0;j<=m+1;j++) a[0][j]=a[n+1][j]=1;
		cin>>sx>>sy>>fx>>fy;
		cout<<BFS();
	}	
	int BFS()
	{
		queue< pair<int,int> > Q;
		Q.push(make_pair(sx,sy)); a[sx][sy]=1;
		while(Q.size())
		{
			pair<int,int> u=Q.front(); Q.pop();
			pair<int,int> Next[]={{u.first-1,u.second},{u.first+1,u.second},{u.first,u.second-1},{u.first,u.second+1}};
			for(auto v:Next)
			if(a[v.first][v.second]==0)
			{
				a[v.first][v.second]=a[u.first][u.second]+1;
				Q.push(v);
			}	
			if(a[fx][fy]) return a[fx][fy]-1;
		}	
		return -1;
	}
};
int main()
{
	mecung M; M.sol();
}


