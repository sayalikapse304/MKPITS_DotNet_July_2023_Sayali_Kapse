#include<stdio.h>
int main()
{
	int arr[3][3];
	int i,j;
	int sum_even,sum_odd;
	for(i=0;i<3;i++)
{
	for(j=0;j<3;j++)
	{ 
	printf("\n enter element of array");
	scanf("%d",&arr[i][j]);
}
}
sum_even=0;
sum_odd=0;
for(i=0;i<3;i++)
{
	for(j=0;j<3;j++)
	{ 
	if(arr[i][j]%2==0)
	{
		sum_even=sum_even+arr[i][j];
	}
	else
	sum_odd=sum_odd+arr[i][j];
}
}
printf("\n sum of even no=%d",sum_even);
printf("\n sum of odd no=%d",sum_odd);
	}

