#include<bits/stdc++.h>
#define ll long long
using namespace std;
int d, n;  
int dd[50] = {};
void TRY(vector<int> a){
	if(a.size() == n){
		d++;
		for(int i=0; i<n; i++) cout<<a[i]<<" ";
		cout<<"\n"; 
		return; 
	}
	for(int i=1 ;i<=n; i++){
		if(!dd[i] && (a.size() == 0 || (a.back()+i) % 4 != 0) ) 
		{
			a.push_back(i);
			dd[i] = 1;
			TRY(a);
			dd[i] = 0;
			a.pop_back();
		}
	} 
} 
int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);
	cin>>n; vector<int>s; 
	TRY(s); 
	cout<<d;
}


