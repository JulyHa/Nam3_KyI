#include<bits/stdc++.h>
using namespace std;

struct ss
{
	int operator()(int a,int b){return a%3==b%3?a>b:a%3>b%3;}
};
int main()
{
	priority_queue<int,vector<int>,ss> Q;
	int n,x;
	cin>>n;
	while(n--) {cin>>x; Q.push(x);}
	while(Q.size()) {cout<<Q.top()<<" "; Q.pop();}
}


