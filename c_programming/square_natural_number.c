#include<stdio.h>
int main()
{
	int num,i,sum=0;
	printf("\nenter number");
	scanf("%d",&num);
	printf("\n the square natural numbers are:");
	for(i=1;i<=num;i++)
	{
		printf("\n%d",i*i);
		sum+=i*i;
	}
	printf("\nsum of square natural number is%d",sum);
}
