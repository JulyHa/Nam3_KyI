#include<bits/stdc++.h>
#define ll long long
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int a[101][101]={};
	int n;
	cin>>n;
	for(int i=1;i<=n;i++){
		for(int j=1;j<=n;j++){
			cin>>a[i][j]; 
		} 
	} 
	int m =a[1][1];
	for(int i = 1; i<=n; i++){
		for(int j = 1; j<=n; j++){
			a[i][j] += a[i-1][j]+ a[i][j-1] - a[i-1][j-1]; 
			m = max(a[i][j], m);
		} 
	} 
	for(int i=1; i<n; i++){
		for(int j=1; j<n; j++){
			for(int u = 1; u<i; u++){
				for(int v = 1; v<j ; v++){
					int s = a[i][j] - a[i][v] - a[u][j] + a[u][v];
					m = max(m, s);
				}
			}
			
		}
	} 
	cout<<m; 
}


