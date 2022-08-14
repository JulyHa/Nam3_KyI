//Tinh to hop dung de quy
#include<bits/stdc++.h>
using namespace std;

long long C(int k,int n)
{
	if(k<=0 || k>=n) return 1;
	return C(k-1,n-1)+C(k,n-1);
}
//Khong gian K(n)=1+2+...+2^n (2^(n+1)-1) = O(2^n)
//Thoi gian  T(n) = 8*(1+2+...+2^n) = O(2^n)

map< pair<int,int> ,long long> M;
long long T(int k,int n)
{
	if(M.find({k,n})!=M.end()) return M[{k,n}];
	if(k<=0 || k>=n) return M[{k,n}]=1;
	return M[{k,n}]=T(k-1,n-1)+T(k,n-1);
}
int main()
{
	cout<<T(23,37);

}


