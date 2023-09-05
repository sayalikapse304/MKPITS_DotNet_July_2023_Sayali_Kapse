#include<stdio.h>
int main()
{
	int num,i,sum=0;
	printf("\n enter no");
	scanf("%d",&num);
	for(i=1;i<num;i++)
	{
		if(num%i==0)
		{
			sum=sum+i*i*i;
		}
		if(sum==num)
		printf("%d is armstrong number\n",num);
		else
		printf("%d is not a armstrong number\n",num);
	}
}
