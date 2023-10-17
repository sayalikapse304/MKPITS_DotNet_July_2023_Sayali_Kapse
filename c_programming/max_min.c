#include<stdio.h>
int main()
{
	int i,max,min,num,arr[100];
	printf("\n enter the value");
	scanf("%d",&num);
	printf("\n enter number");
	for(i=0;i<num;i++)
	{
	scanf("%d",&arr[i]);
}
max=arr[0];
	min=arr[0];
	for(i=0;i<num;i++)
	{
		if(arr[i]>max)
		{
			max=arr[i];
		}
		if(arr[i]<min)
		{
			min=arr[i];
		}
	}
	printf("\n maximum element is=%d",max);
	printf("\n minimum element is=%d",min);
		}
