#include<stdio.h>
int avarage(int n1,int n2,int n3,int n4,int n5)
{
	float tot=n1+n2+n3+n4+n5;
	float avr=tot/5;
	return avr;
}
int main()
{
	int num1,num2,num3,num4,num5;
	float tot;
	printf("enter any 5 no");
	scanf("%d%d%d%d%d",&num1,&num2,&num3,&num4,&num5);
float avr=avarage(num1,num2,num3,num4,num5);
tot=num1+num2+num3+num4+num5;
printf("\ntotal=%f",tot);
	printf("\navarage=%f",avr);
}
