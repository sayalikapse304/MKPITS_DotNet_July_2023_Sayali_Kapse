#include<stdio.h>
void avarage(int n1,int n2,int n3,int n4,int n5)
{
	float tot,avr;
	 tot=n1+n2+n3+n4+n5;
	 avr=tot/5;
	printf("\n total =%f",tot);
	printf("\n avarage=%f",avr);
}
int main()
{
	int num1,num2,num3,num4,num5;
	printf("\n enter any 5 numbers");
	scanf("%d%d%d%d%d",&num1,&num2,&num3,&num4,&num5);
	avarage(num1,num2,num3,num4,num5);
}
