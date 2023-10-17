#include<stdio.h>
int primenumber(int)
{
		int num;
	printf("\n enter a no");
	scanf("%d",&num);
	int counter=0;
	for(int i=1;i<=num;i++)
	{
		if(num%i==0)
		{
			counter++;
		}
		if(counter==2)
		printf("\n the no is prime");
		else
		printf("\n not prime");
	}
	int main()
	{
	 primenumber(num);
	}
	}	
