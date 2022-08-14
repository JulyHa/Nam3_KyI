#include<bits/stdc++.h>
#define ll long long
#define f first
#define s second
using namespace std;
int a[105][105];
int df, ds, cf, cs;
int sol(){
	queue< pair<int,int> > Q;
	Q.push(make_pair(df, ds));
	while(!Q.empty()){
		pair<int,int> u = Q.front(); Q.pop();
		pair<int,int> Next[] = {{u.f-1, u.s},{u.f, u.s-1},{u.f, u.s+1},{u.f+1, u.s}};
		for(auto v: Next){
			if(!a[v.f][v.s]){
				a[v.f][v.s] = a[u.f][u.s]+1;
				Q.push(v);
			}
		}
		if(a[cf][cs]) return a[cf][cs];
	}
	return -1;
}
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int n, m;	cin>>n>>m;
	for(int i=0; i<=m+1; i++) a[0][i]=a[n+1][i] = 1; 
	for(int i=0; i<=n+1; i++) a[i][0]=a[i][m+1] = 1; 
	for(int i=1; i<=n; i++) for(int j=1; j<=m; j++) cin>>a[i][j]; 
	cin>>df>>ds>>cf>>cs; 
	
	cout<<sol();

}


