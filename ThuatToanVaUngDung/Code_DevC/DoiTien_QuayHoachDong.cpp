#include<bits/stdc++.h>
#define ll long long
using namespace std;
int MAX = 1e4+1;
map<int, int>M;
void sol(int a[], int n){
	priority_queue< pair<int,int>, vector<pair<int,int>>, greater<pair<int,int>> > Q;
	Q.push({0,0});
	M[0]=0;
	while(Q.size()){
		int u = Q.top().second, v = Q.top().first;
		Q.pop();
		for(int i = 0; i<n; i++){
			if(a[i] + u < MAX && M.find(a[i]+u) == M.end()){
			M[a[i]+u] = v+1;
			Q.push({v+1, a[i]+u});
		}
		}
	}
}

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int n, m,x;
	cin>>n>>m;
	int a[n];
	for(int i=0;i<n;i++){
		cin>>a[i]; 
	} 
	sort(a,a+n,greater<int>());
	sol(a, n);
	while(m--){
		cin>>x;
		if(M.find(x) == M.end()) M[x]=-1;
		cout<<M[x]<<"\n";
		 
	}

}
