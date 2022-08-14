//tan suat
#include<bits/stdc++.h>
using namespace std;
int main()
{
	map<string,int> M;
	int n;
	string x;
	cin>>n;
	while(n--) {cin>>x; M[x]++;}
	cin>>n;
	while(n--) {cin>>x; cout<<M[x]<<"\n";}
}


