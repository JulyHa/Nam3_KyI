#include<bits/stdc++.h>
#define ll long long
#define f first
#define s second
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int n, x;
	priority_queue<int> L;	//giam dan
	priority_queue<int,vector<int>,greater<int> > R; //tang dan
	
	cin>>n;
	for(int i=1; i<=n; i++){
		cin>>x;
		i%2?L.push(x):R.push(x);
		if(i > 1 && L.top() > R.top()){
			int u = L.top(); L.pop();
			int v = R.top(); R.pop();
			L.push(v);
			R.push(u);
		}
		cout<<L.top()<<" ";
	}
}
