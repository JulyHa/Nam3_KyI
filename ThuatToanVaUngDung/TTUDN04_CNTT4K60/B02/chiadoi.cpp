#include<bits/stdc++.h>
using namespace std;

double find(double a,double b, double f(double))
{
	while(b-a>1e-7)
	{
		double c=(a+b)/2;
		if(f(a)*f(c)<=0) b=c;
		else a=c;
	}
	return (a+b)/2;
}
int main()
{
	cout<<setprecision(20)<<fixed<<"Pi = "<<find(3,3.5,sin);

}


