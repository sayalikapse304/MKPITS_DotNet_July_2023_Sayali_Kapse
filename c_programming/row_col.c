#include<stdio.h>
int main()
{
	int col,row,k=1;
	for(row=1;row<=3;row++)
	{
		for(col=1;col<=row;col++)
		{
			printf("\t %d",k++);
		}
		printf("\n");
	}
}
