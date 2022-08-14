#include<bits/stdc++.h>
using namespace std;

struct node
{
	int a;
	node *next;
	node(int z=0,node *N=0){a=z;next=N;}
};
int fun(node *H)
{
	return H->next->a;
}

int main()
{
	node A(3),B(5,&A),*C=new node(7,&B);	 //C->&B->&A
	int &p=fun(C);
	cout<<p;
	cout<<"\nDia chi B.a : "<<&B.a;
	cout<<"\nDia chi p : "<<&p;
	p=10;
	cout<<"\nGia tri: "<<B.a;

}


