#include<stdio.h>
int area(int side1,int side2)
{
	int result=side1*side2;
	return result;
}
int main()
{
	int num1,num2;
	printf("\n enter the area of side");
	scanf("%d%d",&num1,&num2);
int	result=area(num1,num2);
	printf("\n area of squar=%d",result);
}
