#include<stdio.h>
int even(int num)
{
	return(num%2==0);
}
int main()
{
	int n;
	printf("\n enter any number");
	scanf("%d",&n);
	if(even(n))
	{
		printf("\n the number is even");
	}
	else
	{
		printf("\n the number is odd");
	}
	}
