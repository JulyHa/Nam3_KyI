#include<bits/stdc++.h>
using namespace std;
int main()
{
	int n,m,k;
	cin>>n>>m>>k;
	if(k%__gcd(n,m)) {cout<<"Khong dong duoc nuoc"; return 0;}
	queue< pair<int,int> > Q;
	map< pair<int,int>, int> M;
	Q.push({0,0}); M[make_pair(0,0)]=1;
	while(Q.size())
	{
		pair<int,int> u=Q.front(); Q.pop();
		int x=u.first,y=u.second,z=x+y;
		pair<int,int> Next[]={{0,y}, {x,0}, {n,y}, {x,m}, {max(0,z-m),min(z,m)}, {min(z,n),max(0,z-n)}};
		for(auto v:Next)
		if(!M[v]) 
		{
			M[v]=M[u]+1;
			Q.push(v);
			if(v.first==k || v.second==k) {cout<<M[u]; return 0;}
		}
	}
}


