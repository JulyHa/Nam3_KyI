#include<bits/stdc++.h>
using namespace std;
int main()
{
	int a[]={0,1,7,5},M=15;
	int x,y,z,,res=1e9; //toi uu x+y+z sao cho 1*x+7*y+z*5=15
	
	for(x=0;x*a[1]<=M;x++)
	for(y=0;x*a[1]+y*a[2]<=M && x+y<res;y++)
	{
		z=(M-x*a[1]-y*a[2])/a[3];
	}
}


