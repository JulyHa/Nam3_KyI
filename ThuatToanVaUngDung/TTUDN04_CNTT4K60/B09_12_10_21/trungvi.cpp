#include<bits/stdc++.h>
using namespace std;
struct node
{
	int elem,n;
	node *L,*R;
	node(int x) {elem=x;n=1;L=R=0;}	
};

void add(node *&H,int x)
{
	if(!H) H=new node(x);
	else {H->n++; add(x<=H->elem?H->L:H->R,x);}
}
int find(node *H,int k)
{
	int d=H->L?H->L->n:0;
	if(k==d+1) return H->elem;
	if(k<=d) return find(H->L,k);
	return find(H->R,k-d-1);
}
int main()
{
	node *H=0;
	int n,x;
	cin>>n;
	for(int i=1;i<=n;i++) 
	{
		cin>>x;
		add(H,x);
		cout<<find(H,(i+1)/2)<<" ";
	}
}


