#include<bits/stdc++.h>
#define endl '\n'
using namespace std;
#define ll long long
#define N 100
int p[N + 5][N + 5][15];

int main(){
	ios::sync_with_stdio(0);
	cin.tie(0);	
	int n, q, c; cin >> n >> q >> c;
	for(int i = 0; i < n; ++i){
		int x, y, s; cin >> x >> y >> s;
		p[x][y][s]++;
	}
	
	for(int x = 1; x <= c; ++x)
	for(int i = 1; i <= N; ++i)
	for(int j = 1; j <= N; ++j) p[i][j][x] += p[i - 1][j][x] + p[i][j - 1][x] - p[i - 1][j - 1][x];
	
	while(q--){
		int t, x1, y1, x2, y2; cin >> t >> x1 >> y1 >> x2 >> y2;
		t %= (c + 1);
		int res = 0;
		for(int i = 1; i <= c; ++i) res += (p[x2][y2][i] - (p[x1 - 1][y2][i] + p[x2][y1 - 1][i] - p[x1 - 1][y1 - 1][i])) * ((t + i) % (c + 1));
		cout << res << endl;
	}
	return 0;
}
