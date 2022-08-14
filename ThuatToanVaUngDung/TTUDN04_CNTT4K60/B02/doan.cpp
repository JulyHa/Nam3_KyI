//Cho diem M va doan AB tim diem tren doan AB gan M nhat
#include<bits/stdc++.h>
using namespace std;
typedef pair<double,double> Diem;
#define x first
#define y second
double kc(Diem A,Diem B)
{
	A.x-=B.x;A.y-=B.y;
	return (A.x*A.x+A.y*A.y);
}
Diem Gan(Diem A,Diem B,Diem M)
{
	while(kc(A,B)>1e-10)
	{
		Diem C={(A.x+B.x)/2,(A.y+B.y)/2};
		kc(A,M)>kc(B,M)?A=C:B=C;
	}
	return A;
}
int main()
{
	Diem A(4,4),B(10,4),M(5,0);
	Diem N=Gan(A,B,M);
	cout<<setprecision(10)<<fixed<<N.x<<"\n"<<N.y;
}


