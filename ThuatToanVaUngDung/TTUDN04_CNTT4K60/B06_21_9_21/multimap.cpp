#include<bits/stdc++.h>
using namespace std;
int main()
{
	multimap<int,int> M;
	map <pair<int,int>,bool> MM;
	M.insert (pair<int,int>(3,5));
	M.insert (pair<int,int>(3,7));
	M.insert (pair<int,int>(4,8));
	M.insert (pair<int,int>(4,2));
	for(auto x:M) cout<<x.first<<" "<<x.second<<"\n";

}


