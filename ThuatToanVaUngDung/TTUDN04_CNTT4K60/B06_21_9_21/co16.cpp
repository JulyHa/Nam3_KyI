#include<bits/stdc++.h>
using namespace std;
int main()
{
	map <int,char> M={{10,'A'},{11,'B'},{12,'C'},{13,'D'},{14,'E'},{15,'F'}};
	int n;
	stack<int> S;
	cin>>n;
	while(n) {S.push(n%16); n/=16;}
	while(S.size())
	{
		if(M.find(S.top())!=M.end()) cout<<M[S.top()]; else cout<<S.top();
		S.pop();
	}
}


