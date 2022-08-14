#include <bits/stdc++.h>
using namespace std;
int main(){
	int n, L, R;
	cin >> n >> L >> R;
	int a, c[n + 5], res = -INT_MAX;
	deque<int> Q;// 
	for(int i = 1; i <= n; i++){
		cin >> a;
		if(i <= L) c[i] = a;
		else{
			while(Q.size() and c[Q.back()] <= c[i - L]) Q.pop_back();
			if(c[i - L] > 0)Q.push_back(i - L);
			while(i - Q.front() > R) Q.pop_front();
			c[i] = a + (Q.size()? c[Q.front()]:0);
		}
		res = res < c[i] ? c[i] : res;
	}
	cout << res;
}

