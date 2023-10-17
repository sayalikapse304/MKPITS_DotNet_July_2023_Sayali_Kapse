#include<stdio.h>
int main()
{
	int result=0;
	int num1,num2;
	int *a,*b;
	printf("\n enter 2 no");
	scanf("%d%d",&num1,&num2);
	a= &num1;
	b= &num2;
	result=*a+*b;
	printf("\n addition of two no=%d",result);
	}
