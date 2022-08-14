//Viete 
#include<bits/stdc++.h>
#define ll long long
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int test;
	cin>>test;
	while(test--){
		ll b,c,s[10005], n, mod = 1e9+7;
		cin>>b>>c>>n;
		s[0]=2;s[1]=-b;
		for(int i=2; i<=n; i++){
			s[i] = (-b*s[i-1]%mod - c*s[i-2]%mod)%mod;
		}
		cout<<(s[n]+mod)%mod<<"\n";
	}

}


