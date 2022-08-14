//sinh dau ngoac
#include<bits/stdc++.h>
using namespace std;

void TRY(string x,int m,int d)  //m so mo chua dung, d so dong chua dung m<=d
{
	if(m==0 && d==0) {cout<<x<<"\n"; return;}
	if(m>0) TRY(x+"(",m-1,d);
	if(m<d) TRY(x+")",m,d-1);
}
int main()
{
	int n;
	cin>>n;
	TRY("",n,n);
}


