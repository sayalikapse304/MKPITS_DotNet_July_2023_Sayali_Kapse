#include<stdio.h>
int main()
{
	int i,j,p,n,arr[50];
	printf("\n enter the value");
	scanf("%d",&n);
printf("enter the num");
		for(i=0;i<n;i++)
		scanf("%d",&arr[i]);
		for(i=0;i<n;i++)
		{
	for(j=i+1;j<n;j++)
	{
		if(arr[i]>arr[j])
	{
		p=arr[i];
		arr[i]=arr[j];
		arr[j]=p;
	}
}
}

		printf("\n the array in asending order");
		for(i=0;i<n;i++)
			printf("%d",arr[i]);
	 }
