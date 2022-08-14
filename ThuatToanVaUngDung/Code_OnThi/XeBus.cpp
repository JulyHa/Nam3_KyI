#include<bits/stdc++.h>
#define ll long long
#define MAX 1e9+7
#define MIN -1e9+7
#define f first
#define s second
using namespace std;
int n, Q, a[10000]={}, dem=0, x[10000];
void TRY(int k, int q){// gia su tren xe có x1...x[k-1]  
	if(k>2*n){
		cout<<"\nTH"<<++dem<<" : ";
		for(int i=1; i<=2*n; i++){
			cout<<(x[i]>n?-x[i]:x[i])<<" ";
		}
	} 
	for(int t = Q==q?n+1:1; t<=2*n; t++){
		if(a[t]==0 && (q>0 || t<=n)){
			a[t]=1; if(t<=n) a[t+n]=0;
			x[k]=t;
			TRY(k+1, q+(t<=n?1:-1));
			a[t]=0; if(t<=n) a[t+n]=1;
		}
	}
} 
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	cin>>n>>Q;
	for(int i=n+1; i<=n*n; i++)a[i]=1;
	TRY(1,0);
}


