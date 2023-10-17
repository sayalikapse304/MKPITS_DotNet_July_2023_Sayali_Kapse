#include<stdio.h>
int main()
{
	int i,j,p,num,arr[50];
	printf("\n enter value");
	scanf("%d",&num);
	printf("\n enter number");
	for(i=0;i<num;i++)
	scanf("%d",&arr[i]);
	for(i=0;i<num;i++)
	{
		for(j=i+1;j<num;j++)
		{
			if(arr[i]<arr[j])
			{
				p=arr[i];
				arr[i]=arr[j];
				arr[j]=p;
			}
		}
	}
	printf("\n the array in desending order ");
	for(i=0;i<num;i++)
	printf("%d",arr[i]);
			}
