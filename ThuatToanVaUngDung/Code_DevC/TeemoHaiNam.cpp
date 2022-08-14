#include<bits/stdc++.h>
#define ll long long
using namespace std;
int arr[1000][1000];
int n;
void ve(int n, int &x, int &y, int k){
	int gt = 1;
	int d = n-1;
	int t = 0;
	while (gt <= n * n)
	{
		for (int i = t; i <= d; i++)
		{
			arr[t][i] = gt;
			if(gt == k){x=t; y=i;}
			gt++;
		}
		for (int i = t + 1; i <= d; i++)
		{
			arr[i][d] = gt;if(gt == k){x=i; y=d;}
			gt++;
		}
		for (int i = d - 1; i >= t; i--)
		{
			arr[d][i] = gt;if(gt == k){x=d; y=i;}
			gt++;
		}
		for (int i = d - 1; i >= t + 1; i--)
		{
			arr[i][t] = gt;if(gt == k){x=i; y=t;}
			gt++;
		}
		t++;
		d--;
	}
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) cout << setw(3) << arr[i][j];
		cout << endl;
	}
	
}
void TRY(int i, int j, int y, int d){
	cout<<"\n"<<i<<","<<j;
	if(i <0 || j <0) return;
	if(arr[i][j] == y){ cout<<d<<"\n"; return;}
	d++;
	if(i>0 && __gcd(arr[i][j], arr[i-1][j]) == 1) TRY(i-1, j, y, d);
	if(j>0 && __gcd(arr[i][j], arr[i][j-1]) == 1) TRY(i, j-1, y, d);
	if(i < n-1 && __gcd(arr[i][j], arr[i+1][j]) == 1) TRY(i+1, j, y, d);
//	if(j <n-1 && __gcd(arr[i][j], arr[i][j+1]) == 1) TRY(i, j+1, y, d);
	
}
void sol(){
	int x, y, fx=0, fy=0; cin>>n>>x>>y;
	ve(n, fx, fy, x);
	cout<<fx<<" "<<fy;
	TRY(fx, fy, y, 0);
}

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int t; cin>>t;
	while(t--){
		sol();
	}
}


