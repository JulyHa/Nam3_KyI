#include<bits/stdc++.h>
#define ll long long
#define f first
#define s second
using namespace std;
int MAX = 0;
map<int,int> M;	// luu so tien da doi va so to
void sol(int a[], int n){
	priority_queue<pair<int,int>, vector<pair<int,int> >, greater<pair<int,int>> > PQ;
	PQ.push({0,0});
	M[0]=0; 
	while(!PQ.empty()){
		int v = PQ.top().f, u = PQ.top().s;
		PQ.pop();
		for(int i=0; i<n; i++)
			if(u+a[i] <= MAX && M.find(u+a[i]) == M.end()){
				M[u+a[i]] = v+1;
				PQ.push({v+1, u+a[i]});
			}
	}
}

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int n, m; cin>>n>>m;
	int a[n+1], t[m+1];
	for(int i=0; i<n; i++) cin>>a[i];
	sort(a,a+n,greater<int>());
	for(int i =0; i<m; i++) cin>>t[i];
	MAX = *max_element(t, t+m);
	
	sol(a, n);
	for(int i =0; i<m; i++) {
		if(M.find(t[i]) == M.end()) M[t[i]]=-1;
		cout<<M[t[i]]<<"\n";
	}
}


