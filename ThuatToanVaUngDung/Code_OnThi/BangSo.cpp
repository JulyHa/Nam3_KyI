#include<bits/stdc++.h>
#define ll long long
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int n,m;
	cin>>n>>m;
	
	int a[n+2][m+2];
	for(int i=0; i<n; i++) for(int j=0; j<m; j++) cin>>a[i][j];
	
	for(int i=1; i<m; i++) a[0][i] += a[0][i-1];
	for(int i=1; i<n; i++) a[i][0] += a[i-1][0];
	
	for(int i=1; i<n; i++) for(int j=1; j<m; j++){
		a[i][j] += max(a[i][j-1], a[i-1][j]);
	}
	cout<<a[n-1][m-1];
	
}
