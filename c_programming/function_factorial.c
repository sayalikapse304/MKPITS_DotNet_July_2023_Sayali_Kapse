#include<stdio.h>
void factorial(int num,int*fact)
{
	*fact=1;
	num=num-1;
}
int main()
{
	int n,factorial;
	printf("\n enter any number");
	scanf("%d",&n);
	factorial(n,&factorial);
	*fact=*fact*num;
	printf("\n factorial of number = %d",factorial);
}

