#include<bits/stdc++.h>
using namespace std;

template <class T>
struct node
{
	T elem;
	node *L,*R;
	node(T x,node<T> *_L=0,node *_R=0) {elem=x; L=_L; R=_R;}
};

template <class T>
struct tree
{
	node<T> *root;
	int n;
		void add(node<T>*&H,T x)
		{
			if(!H) H=new node<T>(x);
			else add(x<=H->elem?H->L:H->R,x);
		}
		node<T>* &find(node<T>*&H,T x)
		{
			if(!H || H->elem==x) return H;
			return find(x<H->elem?H->L:H->R,x);
		}
		T Max(node<T> *H){return H->R?Max(H->R):H->elem;}
		T Min(node<T> *H){return H->L?Min(H->L):H->elem;}
		void remove(node<T>* &H,T x)
		{
			if(!H) return;
			if(H->elem==x) 
			{
				if(!H->L) {H=H->R;}
				else if(!H->R) {H=H->L;}
				else
				{
					T z=Max(H->L);
					H->elem=z;
					remove(H->L,z);
				}
			}
			else if(x<H->elem)remove(H->L,x);
			else remove(H->R,x);
		}
		void inorder(node<T> *H)
		{
			if(H) {inorder(H->L); cout<<H->elem<<" "; inorder(H->R);}
		}
	public:
		tree() {root=0;n=0;}
		void push(T x) {add(root,x); n++;}
		void pop(T x)  
		{
			node<T>*&p=find(root,x);
			if(p) {remove(p,x);n--;}
		}
		void travel() {inorder(root);}
		int size() {return n;}
		bool empty() {return n==0;}
};

int main()
{
	tree<int> T;
	for(int x:{42,34,54,65,432,45,74,853,43,62,52,4,36,36,54,77,47,47,623,26,25,423}) T.push(x);
	cout<<"\nCac gia tri: "; T.travel();
	cout<<"\nsize: "<<T.size();
}


