#include<bits/stdc++.h>
#define ll long long
#define f first
#define s second
using namespace std;
int b[]={-2,-1,2,1};
int a[105][105]={};
int n;
bool sol(int u, int v, int k){
	if(k>n*n){
		for(int i=2; i<n+2; i++){
			for(int j=2; j<n+2; j++) cout<<a[i][j]<<"\t";
			cout<<"\n";
		}
		return true;
	}
	for(auto x:b)
		for(auto y:b)
			if(abs(x) + abs(y) == 3 && a[u+x][v+y] == 0){
				a[u+x][v+y] = k;
				if(sol(u+x, v+y, k+1))return true;
				a[u+x][v+y] = 0;
			}
	return false;
}
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int df, ds; 
	cin>>n;
	cin>> df >> ds;
	a[df+1][ds+1] = 1;
	for(int i=0; i<=n+3; i++)
		a[0][i] = a[1][i] = a[n+2][i] = a[n+3][i] = a[i][0] = a[i][1] = a[i][n+2] = a[i][n+3] = 1;
	
	sol(df+1, ds+1, 2);
	
}


