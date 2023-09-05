#include<stdio.h>
int main()
{
	int arr[3][3];
	int row,col;
	for(row=0;row<3;row++)
{
	for(col=0;col<3;col++)
	{ 
	printf("\n enter element of array");
	scanf("%d",&arr[row][col]);
	}
}
printf("transpose=\n");
for(row=0;row<3;row++)
{
	for(col=0;col<3;col++)
	{ 
		printf("%d\t",arr[col][row]);
	}
	printf("\n");
}
}

