//danh ba
#include<bits/stdc++.h>
using namespace std;
int main()
{
	map<string,int> M;
	int n;
	string x,y;
	cin>>n;
	while(n--)
	{
		cin>>x>>y;
		if(x=="find") cout<<M[y]<<"\n";
		else
		{
			for(int j=1;j<=y.size();j++) M[y.substr(0,j)]++;
		}
	}
}


