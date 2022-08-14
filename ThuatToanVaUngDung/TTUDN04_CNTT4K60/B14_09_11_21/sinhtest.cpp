//sinh test
#include<bits/stdc++.h>
using namespace std;

long long myrand()
{
	return rand()%2000-rand()%8000;
}
int main()
{
	srand(time(0));
	int n=1e5,x=1e3,y=2e4+myrand()%100;
	freopen("a3.in","w",stdout);
	cout<<n<<" "<<x<<" "<<y<<"\n";
	for(int i=1;i<=n;i++) cout<<-myrand()<<" ";
}


