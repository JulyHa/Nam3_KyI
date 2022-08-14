#include<bits/stdc++.h>
#define ll long long
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	int a[]={3,6,7,7,7,8,10,12,15,17}, n = 10;
	
	int *p = lower_bound(a, a+n, 7); // con tro tro vao vi tri dau tien >=x
	int *p = upper_bound(a, a+n, 7); // con tro tro vao vi tri dau tien >x
	
	cout<<"a["<<p-a<<"] = 7";

}


