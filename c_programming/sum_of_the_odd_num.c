#include<stdio.h>
int main()
{
	int i,n,sum=0;
	printf("\n enter number");
	scanf("%d",&n);
	printf("\n the odd numbers are:");
	for(i=1;i<=n;i++)
	{
		printf("\n%d",2*i-1);
		sum+=2*i-1;
	}
	printf("\nsum of odd numbers is %d",sum);	
}
