#include<bits/stdc++.h>
#define ll long long
#define MAX 1e9+7
#define MIN -1e9+7
#define f first
#define s second
using namespace std;
string a, b;
int c[105][105]={}, n,m;
void TRY(int u, int v){
	if(c[u][v]){
		while(c[u][v] == c[u-1][v])u--;
		while(c[u][v] == c[u][v-1])v--;
		TRY(u-1,v-1);
		cout<<a[u];
	}
}
void sol(){
	for(int i=1; i<=n; i++){
		for(int j=1; j<=m; j++){
			if(a[i] == b[j]) c[i][j] = c[i-1][j-1] +1;
			else c[i][j] = max(c[i-1][j], c[i][j-1]);
		}
	}
	cout<<"Do dai lon nhat la: "<<c[n][m]<<"\n";
	cout<<"Xau: ";
	TRY(n,m);
}

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	cin>>a>>b;
	n = a.length(); m = b.length();
	a = "0" +a; b = "0"+b;
	sol();
}


