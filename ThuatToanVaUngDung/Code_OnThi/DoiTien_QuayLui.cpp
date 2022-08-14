#include<bits/stdc++.h>
#define ll long long
#define MAX  1e9+7
#define MIN  -1e9+7
#define f first
#define s second
using namespace std;
int n, M, a[100], res = MAX;
void TRY(int k, int t, int T){
	if(k==n-1){
		if((M-T)%a[n-1] == 0)	res = min(res, t+(M-T)/a[n-1]);
		return;
	}
	for(int x = 0; t+x<res && T+a[k]*x <= M; x++){
		TRY(k+1, t+x, T+a[k]*x);
	}
}
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	cin>>n>>M;
	for(int i=0; i<n;i++)cin>>a[i];
	TRY(0,0,0);
	cout<<res;
}


