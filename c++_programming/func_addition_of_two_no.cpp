#include<iostream>
using namespace std;
void addition(int n1,int n2)
{
	int result=n1+n2;
	cout<<"addition of 2 num="<<result;
}
int main()
{
	int num1,num2;
	cout<<"enter two num";
	cin>>num1>>num2;
	addition(num1,num2);
}
