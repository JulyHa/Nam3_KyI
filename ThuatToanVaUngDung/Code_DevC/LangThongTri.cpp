#include<bits/stdc++.h>
#define ll long long
using namespace std;
void sol(){
	int n, x, y; cin>>n;
	int arr[n][n];
	map<int, int> m;
	for(int i=0;i<n;i++) for(int j=0; j<n; j++){
		cin>>x; arr[i][j] = x;
		m[j]++;
	}
	char tt[n][n]={};
	for(int i=n-1; i>=0; i--){
		for(int j= 0; j<n; j++){
			if((arr[j][i] == 1 && m[j] == 1) || (i==j)){
				tt[i][j] = 'Y';
			}
			else {
				
			}
		}
	}
	
}
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	
	int t; cin>>t;
	while(t--){
		sol();
	}
}


