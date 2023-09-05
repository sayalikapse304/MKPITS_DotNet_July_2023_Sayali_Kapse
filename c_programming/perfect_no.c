#include<stdio.h>
int main()
{
	int num,i,sum=0;
	printf("\n enter number");
	scanf("%d",&num);
	printf("factores of %d are\n",num);
	for(i=1;i<=num;i++)
	{
		if(num % i == 0)
		{
			printf("%d\n",i);
			sum+=1;
		}
		if(sum==num)
		printf("%d is a perfect number\n",num);
		else
		printf("%dis not a perfect number\n",num);
	}
		}
		

