#include<bits/stdc++.h>
#define ll long long
#define x first
#define y second 
using namespace std;
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	
	int n, q, c, t, x1, y1, x2, y2, d;
	cin>>n>>q>>c;   // n la so ngoi sao, q so lan nhin, c do sang toi da
	int p[15][102][102]={};
	int xi, yi, si;
	for(int i=0;i<n;i++){
		cin>>xi>>yi>>si;	// xi, yi la toa do, si do sang ban dau
		p[si][xi][yi]++;
	}
	for(int t=1; t<=c; t++) for(int i=1; i<=100; i++) for(int j=1; j<=100; j++){  //dem so luong diem co do sang ban dau la t tai hcn co dinh (0,0) va (i,j) 
		p[t][i][j] +=  p[t][i-1][j] + p[t][i][j-1] - p[t][i-1][j-1];
	}
	while(q--){
		d=0;
		cin>>t>>x1>>y1>>x2>>y2;
		for(int i=1; i<=c; i++){
			d+= (p[i][x2][y2] - p[i][x1-1][y2] - p[i][x2][y1-1] + p[i][x1-1][y1-1] ) * ((i+t%(c+1))%(c+1)); 
		}
		cout<<d<<"\n";
	}
}
