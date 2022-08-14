//Diem Fecma
#include<bits/stdc++.h>
using namespace std;
typedef pair<double,double> Diem;
#define x first
#define y second
double kc(Diem A,Diem B)
{
	A.x-=B.x;A.y-=B.y;
	return sqrt(A.x*A.x+A.y*A.y);
}
Diem fecma(Diem A,Diem B,Diem C)
{
	Diem M={(A.x+B.x+C.x)/3,(A.y+B.y+C.y)/3};
	double eps=10,res=kc(M,A)+kc(M,B)+kc(M,C);
	while(eps>1e-7)
	{
		Diem Next[]={{M.x-eps,M.y},{M.x+eps,M.y},{M.x,M.y-eps},{M.x,M.y+eps}};
		bool ok=0;
		for(auto N:Next)
		{
			double k=kc(N,A)+kc(N,B)+kc(N,C);
			if(k<res) {res=k;M=N;ok=1;}
		}
		if(ok==0) eps/=2;
	}
	return M;
}
int main()
{
	Diem A,B,C,F;
	cin>>A.x>>A.y>>B.x>>B.y>>C.x>>C.y;
	F=fecma(A,B,C);
	cout<<setprecision(3)<<fixed<<F.x<<" "<<F.y;
}


