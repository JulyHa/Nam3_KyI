//ICT-K62+HUST = N
#include<bits/stdc++.h>
#define ll long long
using namespace std;
class ict{
	int n, dem=0, d[11]={1}, x[6]; //x[1]=I, x[2]=C, x[3]=T, x[4]=K
	void Try(int k){ 
		if(k>4){
			int s=n+x[4]*100+62-x[1]*100-x[2]*10-x[3]-x[3];
			if(s%10==0 && s>=1000 && s<1e4){
				s/=10;
				int H = s/100; s%=100;
				int U = s/10;
				int S = s%10;
				if(d[H]+d[U]+d[S]==0 && (H-U)*(U-S)*(S-H)!=0){
					dem++;
					printf("\n%d%d%d-%d62+%d%d%d%d =%d", x[1], x[2], x[3], x[4], H, U, S, x[3], n);
				}
			}
			return;
		}
		for(int t=1; t<=9; t++){
			if(d[t]==0){
				x[k] = t;
				d[t]=1;
				Try(k+1);
				d[t]=0;
			}
		}
	}
	public:
		void sol(){
			cin>>n;
			if(n%2){
				printf("0"); return;
			}
			Try(1);
			cout<<dem;
		}
};
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	ict c;
	c.sol();
}


