#include<bits/stdc++.h>
#define ll long long
#define f first
#define s second
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int n,m,k; cin>>n>>m>>k;
	if(k%__gcd(n,m)) {
		cout<<"Khong dong duoc nuoc";
		return 0; 
	}
	queue< pair<int, int>> Q ;
	map<pair <int,int>, int> M;
	Q.push({0,0}); M[make_pair(0,0)] = 1;
	
	pair<int, int> u;
	int x, y, z;
	while(Q.size()){
		u = Q.front(); Q.pop(); 
		x = u.f, y = u.s;
		z = x+y;
		pair<int, int> next[]={{0,y}, {x,0}, {n,y}, {x,m}, {max(0, z-m), min(z,m)}, {min(z,n), max(0, z-n)}};
		for(auto v: next){
			if(!M[v]){
				M[v] = M[u]+1;
				Q.push(v);
				if(v.f == k || v.s == k){
					cout<<M[v]-1;
					return 0;
				}
			}
		}
	} 
	
		

}


