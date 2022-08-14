//con ma di tuan
#include<bits/stdc++.h>
using namespace std;
class Knight
{
	int a[30][30]={},n;
	void xuat()
	{
		for(int i=2;i<=1+n;i++)
		{
			cout<<"\n";
			for(int j=2;j<=1+n;j++) cout<<setw(3)<<a[i][j];
		}
	//	system("pause");
	}
	public:void sol()
	{
		cout<<"Nhap n = "; cin>>n;
		for(int i=0;i<=n+3;i++) 
		a[0][i]=a[1][i]=a[n+2][i]=a[n+3][i]=a[i][0]=a[i][1]=a[i][n+2]=a[i][n+3]=1;
		cout<<"Nhap xuat phat : ";
		int s,f;
		cin>>s>>f;
		a[s+1][f+1]=1;
		//xuat();
		TRY(s+1,f+1,2);
	}
	bool TRY(int u,int v,int k)
	{
		if(k>n*n) {xuat();return true;}
		for(int i=-2;i<=2;i++)
		for(int j=-2;j<=2;j++)
		if(abs(i)+abs(j)==3 && a[u+i][v+j]==0) 
		{
			a[u+i][v+j]=k;
			if(TRY(u+i,v+j,k+1)) return true;
			a[u+i][v+j]=0;
		}
		return false;
	}
};

int main()
{
	Knight K; K.sol();

}


