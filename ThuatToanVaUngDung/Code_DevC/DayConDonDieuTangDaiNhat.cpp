#include<bits/stdc++.h>
#define ll long long
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int n,x;
	cin>>n;
	vector<int> c;
	while(n--){
		cin>>x;
		if(c.empty() || c.back() < x) c.push_back(x);
		else{
			*lower_bound(c.begin(), c.end(), x) = x;
		}
	}
	cout<<c.size();
}


