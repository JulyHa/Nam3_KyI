//Thuat toan sap xep dem - counting sort
//vi du xau ky tu cac chu cai thuong tieng anh -> sap xep tang danh
//anhban -> aabnnh
#include<bits/stdc++.h>
using namespace std;
int main()
{
	char x[100004];
	scanf("%s",x);
	int f[200]={};   //a->97, b->98
	for(int i=0;x[i];i++) f[x[i]]++; 	
	char*p=x;
	for(char c='a';c<='z';c++) //26*n ->O(n)
		while(f[c]) {*p++=c;f[c]--;}
	printf("%s",x);
}


