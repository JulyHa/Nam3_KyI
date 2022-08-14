#include<bits/stdc++.h>
using namespace std;
int main()
{
	list<int> D;
	for(int x:{4,7,2,8,3,7,2,4}) x%2?D.push_front(x):D.push_back(x);
	for(int z:D) cout<<z<<" ";

}


