#include<bits/stdc++.h>
using namespace std;

long long gcd(long long a,long b)
{
	return b?gcd(b,a%b):abs(a);
}
//Nhanh nhat T(n)=Omega(1)
//Cham nhat Tim ucln day Fibo   89 55 ->34 ->21->13->8->5->3->2->1 
//Do phuc tap cham T(n) = O(log(max(a,b))
//2*F[n-2] < F[n]=F[n-1]+F[n-2] < 2*F[n-1]
int main()
{
	cout<<gcd(300,-1800)<<" ";

}


