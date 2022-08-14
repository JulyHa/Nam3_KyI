#include<bits/stdc++.h>
#define ll long long
#define f first
#define s second
using namespace std;
void sol(){
	int n, m;
	cin>>n;
	int a[n+1][n+1]={};
	for(int i=1; i<=n; i++) for(int j=1; j<=n; j++) cin>>a[i][j];
	m = a[1][1]; 
	for(int i=1; i<=n; i++) 
	for(int j=1; j<=n; j++){
		a[i][j] += a[i-1][j]+a[i][j-1] - a[i-1][j-1];
		m = max(a[i][j], m); 
	}
	
	for(int i=1; i<n ;i++){
		for(int j=1; j<n; j++){
			for(int x=1; x<i; x++){
				for(int y=1; y<j;y++){
					int s =  a[i][j] - a[i][y] - a[x][j] + a[x][y];
					m = max(s,m); 
				} 
			} 
		} 
	} 
	 cout<<m; 
}

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	sol(); 
}


