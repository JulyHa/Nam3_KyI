#include<bits/stdc++.h>
#define ll long long
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int n;
	cin>>n;
	int a[n];
	for(auto &x:a) cin>>x;
	vector<int> c(1,a[0]);
	for(int i=1; i<n; i++){
		if(a[i] > c.back()) c.push_back(a[i]);
		else{
			auto p = lower_bound(c.begin(), c.end(), a[i]);
			*p = a[i];
		}
	}
	cout<<c.size();
}


