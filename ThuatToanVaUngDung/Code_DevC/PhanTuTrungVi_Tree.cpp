//trung vi
#include<bits/stdc++.h>
using namespace std;
struct node
{
	int e;
	node *L,*R;
	node(int _e=0,node*_L=0,node*_R=0){e=_e;L=_L;R=_R;}
};

int Max(node*H) {return H->R?Max(H->R):H->e;}
int Min(node*H) {return H->L?Min(H->L):H->e;}

void add(node*&H,int x)
{
	if(!H) H=new node(x);
	else add(x<=H->e?H->L:H->R,x);
}
void remove(node*&H,int x)
{
	if(!H) return;
	if(x<H->e) return remove(H->L,x);
	if(x>H->e) return remove(H->R,x);
	if(!H->L) H=H->R;
	else if(!H->R) H=H->L;
	else {H->e=Max(H->L); remove(H->L,H->e);}
}
void inorder(node *H) {if(H) {inorder(H->L); cout<<H->e<<" "; inorder(H->R);}}

int main()
{
	int n,x;
	cin>>n>>x; 
	node*H=new node(x); cout<<x<<" ";	
	for(int i=2;i<=n;i++)
	{
		cin>>x;
		if(i%2==0)
		{
			if(x>=H->e) add(H->R,x);
			else
			{
				add(H->R,H->e);
				if(H->L) 
				{
					int z=Max(H->L);
					if(z>x){H->e=z; remove(H->L,H->e); add(H->L,x);}
					else H->e=x;
				}
				else H->e=x;
			} 
		}
		else
		{
			if(x<=H->e) add(H->L,x);
			else
			{
				add(H->L,H->e);
				if(H->R)
				{
					int z=Min(H->R);
					if(z<x){H->e=z;remove(H->R,H->e); add(H->R,x);}
					else H->e=x;
				}
				else H->e=x;
			} 
		}
//		cout<<"\n";
//		inorder(H);
			cout<<H->e<<" ";
	}
	
}

