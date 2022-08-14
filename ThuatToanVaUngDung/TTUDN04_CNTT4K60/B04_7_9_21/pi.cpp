#include<bits/stdc++.h>
using namespace std;

double ran()   //sinh so ngau nhien trong doan 0,1
{
	return (double)rand() / RAND_MAX;
}
int main()
{
	srand(time(NULL));
	double res=0,n=1e8;
	for(int i=1;i<=n;i++)
	{
		double x=ran(), y=ran()*4;
		if(4/(x*x+1)>=y) res++;	
	}
	cout<<setprecision(20)<<fixed<<"\nPi = "<<res/n*4;
}
