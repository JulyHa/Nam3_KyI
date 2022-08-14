#include<bits/stdc++.h>
#define ll long long
#define f first
#define s second
using namespace std;
int n,m, k, res=35;
int a[35][35]={};  // luu cac mon bi trung gio
int X[35]={}, p[35]={}; 	//X luu mon k ai day va p luu so mon ma gv k day
map<int, set<int>>M; // mon k do nhung ai day
void sol(int k){
	if(k==m){
		res = min(*max_element(p, p+n), res);
		return;
	}
	if(X[k]) sol(k+1);
	else{
		for(auto t : M[k]){  // mon k co t gv
			if(p[t] < res-1){
				int ok=1;
				for(int i=0; i<m; i++){
					if(X[i] == t && a[i][k] == 1){ ok=0; break;}
				}
				if(ok){
					X[k] = t;
					p[t]++;
					sol(k+1);
					X[k]=0;
					p[t]--;
				}
			}
		}
	}
}
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int u, v;
	cin>>n>>m;
	for(int i=0; i<n; i++){
		cin>>k;
		while(k--){
			cin>>u;
			M[u].insert(i); // Mon u duoc giang day boi gv i
		}
	}
	cin>>k;
	while(k--){
		cin>>u>>v;
		a[u][v] = a[v][u] = 1;
	}
	for(int i=0; i<m; i++){
		if(M[i].size() == 1){
			int sub = *M[i].begin();
			X[i] = sub; // mon i duoc giang day boi sub
			p[sub]++; // gv sub day p[sub] mon
		}
	}
	sol(0);	
	cout<<res;	
	
}


