#include<bits/stdc++.h>
#define ll long long
#define f first
#define s second
using namespace std;
int n, res = 99999999; 
int a[20][20];
int d[10]={}; 
void sol(int k, int x, int T){ // k la so dinh da di //x là dinh den // T la trong so 
	if(k==n){
		res = min(res, T+a[x][0]);
		return; 
	} 
	for(int i=1 ;i<n; i++){
		if(!d[i]) {
			d[i]=1;
			if(T+a[x][i] < res) sol(k+1,i,T+a[x][i]);
			d[i]=0;
		}
	}
}
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	cin>>n;
	for(int i=0; i<n; i++) for(int j=0; j<n; j++) cin>>a[i][j];
	sol(1,0,0); 
	cout<<res;
}


