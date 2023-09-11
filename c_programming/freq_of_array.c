#include<stdio.h>
int main()
{
	int i,j,count,num,arr[100],freq[50];
	printf("\n enter value");
	scanf("%d",&num);
	printf("\n enter number");
	for(i=0;i<num;i++)
	{
	scanf("%d",&arr[i]);
	freq[i]=-1;
}
for(i=0;i<num;i++)
{
	count=1;
	for(j=i+1;j<num;j++)
	{
		if(arr[i]==arr[j])
		{
			count++;
			freq[j]=0;
		}
	}
	if(freq[i]!=0)
	{
		freq[i]=count;
	}
}
printf("\n frequence of all elements of array");
for(i=0;i<num;i++)
{
	if(freq[i]!=0)
	{
		printf("\n%d occurs %d time\n",arr[i],freq[i]);
	}
}
	}
