#include<bits/stdc++.h>
#define ll long long
#define MAX  1e9+7
#define MIN  -1e9+7
#define f first
#define s second
using namespace std;
int n, m, a[100], C[100][100]={};
void TRY(){
	for(int i=1; i<=m;i++) C[0][i]=MAX;
	for(int i=1; i<=n; i++)
		for(int j=0; j<=m; j++){
			if(a[i]>j) C[i][j] = C[i-1][j];
			else C[i][j] = min(C[i-1][j], C[i][j-a[i]]+1);
		}
}
string TruyVet(int x, int y){
	if(C[x][y]==0) return "";
	while(C[x][y] == C[x-1][y])x--;
	return TruyVet(x,y-a[x]) + "+" +to_string(a[x]);
}
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	cin>>n>>m;
	for(int i=1; i<=n; i++) cin>>a[i];
	TRY();
	if(C[n][m] == MAX) cout<<"-1";
	else cout<<C[n][m]<<"\n";
	cout<<TruyVet(n,m).substr(1);
}


