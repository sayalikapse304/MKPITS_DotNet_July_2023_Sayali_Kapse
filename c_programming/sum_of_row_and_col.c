#include<stdio.h>
int main()
{
	int arr[20][20],row[20],col[20];
	int i,j,sum,n;
	printf("\n size of matrix");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		for(j=0;j<n;j++)
		{
			printf("\n enter row and col");
			scanf("%d",&arr[i][j]);
		}
	}
	printf("\n the matrix is\n");
	for(i=0;i<n;i++)
	{
		for(j=0;j<n;j++)
			printf("%d\t",arr[i][j]);
			printf("\n");
	}
			for(i=0;i<n;i++)
			{
				row[i]=0;
				for(j=0;j<n;j++)
				row[i]=row[i]+arr[i][j];
			}
			for(i=0;i<n;i++)
			{
				col[i]=0;
				for(j=0;j<n;j++)
				col[i]=col[i]+arr[j][i];
			}
			printf("\n the sum of the row and matrix:\n");
			for(i=0;i<n;i++)
			{
				for(j=0;j<n;j++)
				printf("%d\t",arr[i][j]);
				printf("%d\t",row[i]);
				printf("\n");
			}
			printf("\n");
			for(j=0;j<n;j++)
			{
				printf("%d\t",col[j]);
			}
			printf("\n\n");
		}
