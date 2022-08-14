#include<bits/stdc++.h>
using namespace std;
int main()
{
	map< int, set<int> > M;// M[i] chua nhung nguoi tiep xuc voi i 
	int n,m,u,v;
	cin>>n>>m;
	while(m--) {cin>>u>>v; M[u].insert(v); M[v].insert(u);}
	int F[n+5]={};// sl nguoi bi cua moi loai 
	cin>>F[0];
	map<int,int> D; //danh dau nguoi i la F may 
	queue<int> Q;
	for(int i=1;i<=F[0];i++) {cin>>u; Q.push(u); D[u]=1;}
	while(Q.size())
	{
		u=Q.front();Q.pop();
		for(int v:M[u])
		if(!D[v])
		{
			D[v]=D[u]+1;
			F[D[u]]++;
			Q.push(v);
		}
	}
	for(int i=0;F[i];i++) cout<<"F"<<i<<": "<<F[i]<<endl;
}


