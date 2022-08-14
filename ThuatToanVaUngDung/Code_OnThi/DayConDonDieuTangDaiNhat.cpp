#include<bits/stdc++.h>
#define ll long long
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	
	int n, x; cin>>n;
	vector<int>a;
	for(int i=0; i<n; i++) {
		cin>>x;
		if(a.empty() || a.back() < x) a.push_back(x);
		else{
			*lower_bound(a.begin(), a.end(), x) = x;
		}
	} 
	cout<<a.size();
	
}


