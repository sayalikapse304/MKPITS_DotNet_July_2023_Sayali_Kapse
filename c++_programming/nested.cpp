#include<iostream>
using namespace std;
int main()
{
	int row,col,k=1;
	for(row=1;row<=5;row++)
	{
		for(col=1;col<=row;col++)
		{
			cout<<"\t"<<k++;
		}
		cout<<"\n";
	}
		return 0;
		}

