#include<bits/stdc++.h>
using namespace std;

class BCA {
		int m,n, C[35][35]= {}, X[35]={}, res=35, p[35]= {};
		map<int, set<int>> A; //Mon k do nhung ai day
		public: void sol() {
			int k, u, v,w;
			scanf("%d%d",&m,&n);
			for(int i=1; i<=m; i++) {
				scanf("%d",&k);
				while(k--) {
					scanf("%d",&u);
					A[u].insert(i);
				}
			}
			scanf("%d",&k);
			while(k--) {
				scanf("%d%d",&v,&w);
				C[w][v]=C[v][w]=1;
			}
			for(int i=1;i<=n;i++)
			if(A[i].size()==1) 
			{
				int sub=*A[i].begin();
				X[i]=sub;
				p[sub]++;
				
			}
			TRY(1);
			printf("%d",res);
		}
		void TRY(int k) { //da co x1...x[k-1]
			if(k>n) {
				int kq=*max_element(p+1,p+m+1);
				if(res>kq) res=kq;
				return;
			}
			if(X[k])
			{
//				int ok=1;
//				for(int i=1; i<k && ok; i++) if(X[i]==X[k] &&C[i][k]==1) ok=0;
//				if(ok) 
				TRY(k+1);
			}
			else for(int t:A[k])
			if(p[t]<res-1)
			{
				int ok=1;
				for(int i=1; i<n && ok; i++) if(X[i]==t&&C[i][k]==1) ok=0;
				if(ok) {
					X[k]=t;
					p[t]++;
					TRY(k+1);
					X[k]=0;
					p[t]--;
				}
			}
		}
};

int main() {
	BCA B;
	B.sol();
}
