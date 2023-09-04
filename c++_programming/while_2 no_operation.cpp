#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0,count=0;
	char op;
	cout<<"\n enter 2 no";
	cin>>n1>>n2;
	cout<<"\n enter op(+,*,/,*)";
	cin>>op;
	while(count>sum)
	count++;
	if(op=='+')
	{
		sum=n1+n2;
	}
	else if(op=='-')
	{
		sum=n1-n2;
	}
	else if (op=='/')
	{
		sum=n1/n2;
	}
	cout<<"sum="<<sum;
	}
