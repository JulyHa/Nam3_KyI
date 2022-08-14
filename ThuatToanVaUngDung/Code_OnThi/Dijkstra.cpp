#include<bits/stdc++.h>
using namespace std;
int main()
{
	int n,m,s;
	cin>>n>>m;
	vector<pair<int,int> > A[n+5];//first - do dai, second -dinh  //A[1] = {<16,2>,<14,4>}	//A[3] = {<7,1>,<2,4>,<12,5>,<2,6>}
	for(int i=1;i<=m;i++)
	{
		int u,v,w;
		cin>>u>>v>>w; A[u].push_back({w,v});
	}
	cin>>s;
	priority_queue<pair<int,int>,vector<pair<int,int>>,greater<pair<int,int>> > Q;//Q- chua cac pair: first do dai tu dinh xp den dinh second
	map<int,int> M; //chua do dai duong di ngan nhat
	for(int i=1;i<=n;i++) M[i]=1e9;
	M[s]=0;
	Q.push({0,s});
	while(Q.size())
	{
		pair<int,int> u=Q.top(); Q.pop(); 
		if(u.first>M[u.second]) continue; // neu tai dinh dang xet ma do dai lay ra > do dai ngan nhat o dinh do=> Ko xet
		int len=u.first; 
		for(pair<int,int> v:A[u.second])  // duyet tat ca cac dinh ke cua dinh dang xet
		if(M[v.second]>len+v.first)
		{
			M[v.second]=len+v.first;
			Q.push({M[v.second],v.second});
		}
	}
	for(int i=1;i<=n;i++) 
	if(M[i]==1e9) cout<<"Khong co duong di tu "<<s<<" den "<<i<<"\n";
	else cout<<s<<" -> "<<i<<" : "<<M[i]<<"\n";
}


