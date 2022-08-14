#include<bits/stdc++.h>
#define ll long long
#define x first
#define y second 
using namespace std;
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	
	int n, d, c, t, x1, y1, x2, y2;
	cin>>n>>d>>c;
	pair<pair<int,int> ,vector<int>> q[100];
	int a[c]={};
	for(int i=0;i<n;i++){
		cin>>q[i].x.x>>q[i].x.y>>t;
			cout<<q[i].x.x<<" "<<q[i].x.y;
		q[i].y[t]++;
		cout<<q[i].x.x<<" "<<q[i].x.y<<" "<<q[i].y[t]<<"\n";
	}

			
//	
//	for(int t=1; t<=c; t++) for(int i=1; i<=100; i++) for(int j=1; j<=100; j++){
//		p[t][i][j] +=  p[t][i-1][j] + p[t][i][j-1] - p[t][i-1][j-1];
//	}
//	
//	
//	
//	
//	int p[15][102][102];
//	int xi, yi, si;
//	for(int i=0;i<n;i++){
//		cin>>xi>>yi>>si;
//		p[si][xi][yi]++;
//	}
//	for(int t=1; t<=c; t++) for(int i=1; i<=100; i++) for(int j=1; j<=100; j++){
//		p[t][i][j] +=  p[t][i-1][j] + p[t][i][j-1] - p[t][i-1][j-1];
//	}
//	while(q--){
//		d=0;
//		cin>>t>>x1>>y1>>x2>>y2; 
//		for(int i=1; i<=c; i++){
//			d+= (p[i][x2][y2] - p[i][x1][y1]) * ((i+t%(c+1))%(c+1));
//		}
//		cout<<d<<"\n";
//	}
//	
	
	
	

}


