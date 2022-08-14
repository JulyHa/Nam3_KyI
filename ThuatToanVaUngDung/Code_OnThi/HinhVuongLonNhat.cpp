#include<bits/stdc++.h>
#define ll long long
#define f first
#define s second
using namespace std;
int n, m;
int a[1005][1005]={}, c[1005][1005]={}; // c luu canh hv lon nhat toan 0 or toan 1 ma goc cuoi la hang i cot j 
int sol(int b){
	int res = 0;
	for(int i=1; i<=m; i++) c[1][i] = a[1][i]==b; 
	for(int i=1; i<=n; i++) c[i][1] = a[i][1]==b; 
	
	for(int i=2; i<=n; i++){
		for(int j=2; j<=m;j++){
			if(a[i][j] != b) c[i][j] = 0;
			else {
				int k=min(c[i-1][j], c[i][j-1]);
				if(a[i-k][j-k] == b) k++;
				c[i][j]=k;
				if(res < k) res = k;
			}
		}
	}
	return res;	 
}

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	cin>>n>>m;
	for(int i=1; i<=n; i++) for(int j=1; j<=m; j++) cin>>a[i][j];
	cout<<max(sol(0), sol(1));
}


