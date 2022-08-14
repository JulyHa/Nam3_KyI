#include<bits/stdc++.h>
#include<set>
using namespace std;
int main()
{
	set<int> S;
	for(int x:{23,643,457,58,968,18,423,52,243,34,41,62,37,82,363,15,32,58,41}) S.insert(x);
	for(auto s:S) cout<<s<<" ";
}


