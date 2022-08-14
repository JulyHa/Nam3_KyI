#include<bits/stdc++.h>
#include"pq.cpp"
using namespace std;
int main()
{
	//priority_queue<int> Q;  //khai bao hang doi uu tien
	//priority_queue<int,vector<int>,greater <int> > Q;
	pq<int,less<int> > Q;
	for(int x:{4,7,2,8,1,6,4,5,3,5}) Q.push(x);
	while(Q.size())
	{
		cout<<Q.top()<<" ";
		Q.pop();
	}
}


