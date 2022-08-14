#include<bits/stdc++.h>
using namespace std;

struct node
{
	int elem;
	bool color;
	node *L,*R,*F;   //L-left, R-right, F-farther
	node(int x,node *_F=0) {elem=x;L=R=0;F=_F; color=1;}	
};
node *add(node *&H,int x)
{
	if(!H) return H=new node(x);
	if(x<=H->elem) {if(H->L) return add(H->L,x); else {H->L=new node(x,H); return H->L;}}
	else           {if(H->R) return add(H->R,x); else {H->R=new node(x,H); return H->R;}}
}

void right_rotate(node *&Root,node *&H)
{
	node *p=H->L;
	if(H->F) H==H->F->L?H->F->L=p:H->F->R=p;
	H->L=p->R; 
	if(H->L) H->L->F=H;
	p->R=H; 
	p->F=H->F;
	H->F=p;
	if(Root==H) Root=p;
	H=p;
}
void left_rotate(node *&Root,node *&H)
{
	node *p=H->R;
	if(H->F) H==H->F->L?H->F->L=p:H->F->R=p;
	H->R=p->L; 
	if(H->R) H->R->F=H;
	p->L=H; 
	p->F=H->F;
	H->F=p;
	if(Root==H) Root=p;
	H=p;
}

void recolor(node *&Root, node *p)
{
	if(!p->color) return;
	if(p==Root) {Root->color=0; return;}
	if(p->F->color==0) return;
	node *q=p->F,*o=q->F;
	node *r=(q==o->L?o->R:o->L);
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

void print(node *H,string prompt="\n")
{
	if(!H) return;
	print(H->L,prompt+"\t");
	cout<<prompt<<H->elem<<"("<<int(H->color)<<")";
	print(H->R,prompt+"\t");
}

int main()
{
	node *R=0;
	for(int x:{23,643,457,58,968,18,423,52,243,34,41,62,37,82,363,15,32})
	{
		node *p=add(R,x);
		recolor(R,p);
		cout<<"\nThem "<<x<<"\n";
		print(R);
	}

}

