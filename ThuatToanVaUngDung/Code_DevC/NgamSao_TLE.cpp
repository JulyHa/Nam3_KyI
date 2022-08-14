#include<bits/stdc++.h>
#define ll long long
#define x first
#define y second 
using namespace std;
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	
	int n, q, c, t, x1, y1, x2, y2;
	cin>>n>>q>>c;
	pair<int, int>p[n];
	int a[n];
	for(int i=0;i<n;i++)cin>>p[i].x >> p[i].y >>a[i];
	for(int i=0; i<q; i++){
		cin>>t>>x1>>y1>>x2>>y2; 
		int d=0; 
		for(int j=0; j<n; j++){
			if((x1<=p[j].x && p[j].x<= x2) &&(y1 <= p[j].y && y2>= p[j].y)) 
				d+= (a[j]+t%(c+1))%(c+1);
		} 
		cout<<d<<"\n"; 
	} 
}
