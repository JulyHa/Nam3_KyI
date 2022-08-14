#include<bits/stdc++.h>
#define ll long long
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int n; cin >>n;
	ll kq=0;
	int m = -32769; 
	int a[n+5]={}, l[n+5]={}, r[n+5]={};
	
	for(int i=0; i<n; i++) cin>>a[i];
	
	for(int i=0;i<n;i++) {
		l[i] = max(m, a[i]);
		m = l[i]; 
	}
	m = -32769; 
	for(int i=n-1;i>=0;i--) {
		r[i] = max(m, a[i]);
		m = r[i]; 
	}	
	for(int i=0; i<n; i++){
		kq += min(l[i], r[i]) > a[i]? min(l[i],r[i])-a[i] : 0; 
	} 
	cout<<kq; 
	
	

}


