#include<iostream>
using namespace std;
int myfunction(int x,int y)
{
if(y<=0)
{
	return 1;
}
else
{
	return x*(myfunction(x,y-1));
}
}
int main()
{
	int res;
	res=myfunction(5,3);
	cout<<"res="<<res;
	return 0;
}

