#include<bits/stdc++.h>
#define ll long long
using namespace std;
int a[1001][1001]={};

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	
	int n, m;
	cin>>n>>m;

	for(int i=1;i<=n;i++){
		for(int j=1;j<=m;j++){
			cin>>a[i][j]; 
		} 
	} 
	for(int i=2;i<=n;i++) a[i][1] += a[i-1][1];
	for(int i=2; i<=m; i++) a[1][i] += a[1][i-1];
	for(int i = 2; i<=n; i++){
		for(int j = 2; j<=m; j++){
			a[i][j] += max(a[i-1][j], a[i][j-1]); 
		} 
	} 
	cout<<a[n][m]; 
}


