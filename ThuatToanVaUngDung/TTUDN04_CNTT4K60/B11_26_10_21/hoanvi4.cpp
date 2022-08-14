#include<bits/stdc++.h>
#define ll long long
using namespace std;
int n, d = 0;
int dd[21]={};
void Try(vector<int> &kq)
{
	if(kq.size() == n)
	{
		d++;
		for(auto i : kq) printf("%d ", i);
		printf("\n");
	}		
	else{
		for(int i = 1; i<=n; i++)
		{
			if(!dd[i] && (kq.size() == 0 || (i + kq.back()) % 4 ))
			{
				dd[i]=1;
				kq.push_back(i);
				Try(kq);
				kq.pop_back();
				dd[i]=0;
			}
		}
	}
}
int main()
{
	scanf("%d", &n);
	vector<int>s;
	Try(s);
	printf("%d", d);
}
