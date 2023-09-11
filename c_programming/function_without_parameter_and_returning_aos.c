#include<stdio.h>
int area()
{
	int num1,num2;
	printf("enter side");
	scanf("%d%d",&num1,&num2);
	int result=num1*num2;
	return result;
}
int main()
{
	int result=area();
	printf("\n area of square=%d",result);
}
