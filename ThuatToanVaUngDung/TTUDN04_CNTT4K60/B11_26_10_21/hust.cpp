//ICT-K62+HUST=N
#include<bits/stdc++.h>
using namespace std;

class ict
{
	int n,dem=0,d[11]={1},x[6]; //x[1]=I,X[2]=C,x[3]=T,x[4]=K
	public:void sol()
	{
		cin>>n;
		n+=62;
		if(n%2) {printf("0");return;}
		TRY(1);
		cout<<"\n"<<dem;
	}
	void TRY(int k) 
	{
		if(k>4) 
		{
			int s=n+x[4]*100-x[1]*100-x[2]*10-x[3]-x[3];
			if(s%10==0 && s>=1000 && s<1e4)
			{
				s/=10;
				int H=s/100; s%=100;
				int U=s/10; 
				int S=s%10;
				if(d[H]+d[U]+d[S]==0 && (H-U)*(U-S)*(S-H)) 
				{
					dem++;
					printf("\n%d%d%d-%d62+%d%d%d%d = %d",x[1],x[2],x[3],x[4],H,U,S,x[3],n-62);
				}
			}
			return;
		}
		for(int t=1;t<=9;t++)
		if(d[t]==0)
		{
			x[k]=t; d[t]=1; TRY(k+1);
			d[t]=0;
		}
	}  
};

int main()
{
	ict Z; Z.sol();


}


