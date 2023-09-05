#include<stdio.h>
int main()
{
	int row,col,equal=0;
	int i,j;
	int arr1[10][10],arr2[10][10];
	printf("\n enter num of row and col");
	scanf("%d",&row);
	printf("\n enter the 1st matrix element\n");
	for(i=0;i<row;i++)
	{
		for(i=0;i<col;i++)
		{
			scanf("%d\t",&arr1[i][j]);
		}
	}
	printf("\n enter the 2nd matrix element\n");
	for(i=0;i<row;i++)
	{
		for(col=0;col<j;col++)
		{
			scanf("%d\t",&arr2[i][j]);
		}
	}
	for(i=0;i<row;i++)
	{
		for(j=0;j<row;j++)
		{
			if(arr1[i]==arr2[j])
			{
				equal++;
				break;
			}
		}
	}
	if((equal==row)&&(equal==col))
	{
		printf("\n matrix is equal ");
	}
	else
	{
		printf("\n matrix  is not equal ");
	}
}
