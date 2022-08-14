#include<bits/stdc++.h>
#define ll long long
#define MAX 1e9+7
#define MIN -1e9+7
#define f first
#define s second
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int n, L, R; cin>>n>>L>>R;
	int a, c[n+5], res = MIN; 
	deque<int>Q;
	for(int i=1; i<n; i++){
		cin>>a;
		if(i<=L)c[i]=a;
	}
}


