#include<stdio.h>
int main()
{
	int num,i,sum=0;
	printf("\nenter the number");
	scanf("%d",&num);
	printf("\n even numbers are:\n",num);
	for(i=1;i<=num;i++)
	{
		printf("\n%d",2*i);
		sum+=2*i;
	}
	printf("\nsum of even numbers is %d\n",sum);
	}
