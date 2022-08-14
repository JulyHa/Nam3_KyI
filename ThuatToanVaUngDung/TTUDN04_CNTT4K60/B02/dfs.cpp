#include<bits/stdc++.h>
using namespace std;

bool ktnt(int n)
{
	if(n==2) return 1;
	if(n%2==0 || n<3) return 0;
	for(int i=3;i*i<=n;i+=2) if(n%i==0) return 0;
	return 1;
}

int dfs(int n)
{
	if(ktnt(n)) return n;
	int k=dfs(2*n); if(k>-1) return k;
	k=dfs(3*n+1); if(k>-1) return k;
	return -1;
}

int main()
{
	cout<<dfs(4);
}


