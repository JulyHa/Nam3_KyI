//implemention Set container using Red Black Tree 
//Date: 19/10/21 for CNTT4K60 - DHGTVT
//tichpx@utc.edu.vn
#include<bits/stdc++.h>
using namespace std;
#ifndef __MultiSet__cpp__
#define __MultiSet__cpp__
template <class T>
struct node
{
	T elem;
	bool color;
	node<T>*L,*R,*F;   //L-left, R-right, F-farther
	node(T x,node<T>*_F=0) {elem=x;L=R=0;F=_F; color=1;}	
};

template<class T,class Cmp=less<T> >
struct Set
{
	node<T>*root;
	T n;
	Cmp comp;
	node<T>*add(node<T>*&H,T x)
	{
		if(!H) return H=new node<T>(x);
		if(H->elem==x) return 0;
		if(comp(x,H->elem)) {if(H->L) return add(H->L,x); else {H->L=new node<T>(x,H); return H->L;}}
		else               {if(H->R) return add(H->R,x); else {H->R=new node<T>(x,H); return H->R;}}
	}
	void right_rotate(node<T>*&Root,node<T>*&H)
	{
		node<T>*p=H->L;
		if(H->F) H==H->F->L?H->F->L=p:H->F->R=p;
		H->L=p->R; 
		if(H->L) H->L->F=H;
		p->R=H; 
		p->F=H->F;
		H->F=p;
		if(Root==H) Root=p;
		H=p;
	}
	void left_rotate(node<T>*&Root,node<T>*&H)
	{
		node<T>*p=H->R;
		if(H->F) H==H->F->L?H->F->L=p:H->F->R=p;
		H->R=p->L; 
		if(H->R) H->R->F=H;
		p->L=H; 
		p->F=H->F;
		H->F=p;
		if(Root==H) Root=p;
		H=p;
	}
	void recolor(node<T>*&Root, node<T>*p)
	{
		if(!p->color) return;
		if(p==Root) {Root->color=0; return;}
		if(p->F->color==0) return;
		node<T>*q=p->F,*o=q->F;
		node<T>*r=(q==o->L?o->R:o->L);
		if(r && r->color) {q->color=r->color=0; o->color=1; return recolor(Root,o);}
		if(o->L==q)
		{
			if(p==q->R) left_rotate(Root,q);
			right_rotate(Root,o);
			o->color=0; 
			o->R->color=1;
		}
		else
		{
			if(p==q->L) right_rotate(Root,q);
			left_rotate(Root,o);
			o->color=0; 
			o->L->color=1;
		}
	}
	list<T> L;
	void inorder(node<T>*H)
	{
		if(!H) return;
		inorder(H->L);
		L.push_back(H->elem);
		inorder(H->R);
	}
	public:
		typedef typename list<T>::iterator iterator;
		iterator begin() {L.clear(); inorder(root);return L.begin();}
		iterator end() {return L.end();	}
		Set() {root=0;n=0;}
		int size() {return n;}
		bool empty() {return n==0;}
		void insert(T x)
		{
			node<T>*p=add(root,x);
			if(p)	{recolor(root,p); n++;}
		}
		//void erase(T x);
};
#endif
int main()
{
	Set<double,greater<double> > S;
	double a[]={23,643,457,58,968,18.5,423,52,243,34,41,62.7,37,82,363,15,32,58,41};
	for(auto x:a) S.insert(x);
//	for(Set::iterator it=S.begin();it!=S.end();it++) cout<<*it<<" ";
	for(auto x:S) cout<<x<<" ";
}


