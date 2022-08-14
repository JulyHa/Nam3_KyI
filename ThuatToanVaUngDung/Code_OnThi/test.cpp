#include<bits/stdc++.h>
#define ll long long
#define MAX  1e9+7
#define MIN  -1e9+7
#define f first
#define s second
using namespace std;
int n, m, a[100], res = MAX;
map<int, int>M;
int TRY(){
	priority_queue<pair<int ,int>,vector<pair<int,int> >, greater<pair<int,int>> >PQ;
	PQ.push({0,0});
	M[0]=0;
	while(!PQ.empty()){
		int u = PQ.top().s, v = PQ.top().f;
		PQ.pop();
		for(int i=0; i<n; i++){
			if(u+a[i]<=m && M.find(u+a[i]) == M.end()){
				M[u+a[i]] = v+1;
				PQ.push({v+1, u+a[i]});
				cout<<u+a[i]<<" ";
			}
		}
		if(M.find(m) != M.end()){
			return M[m];
		}
	}
	return -1;
}
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	cin>>n>>m;
	for(int i=0; i<n;i++)cin>>a[i];
	sort(a, a+n, greater<int>());
	cout<<TRY();
	
}


