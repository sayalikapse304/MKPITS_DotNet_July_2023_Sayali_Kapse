#include<stdio.h>
void fact(int n,int fact)
{
	printf("\n fact of number=%d",fact);
}
int main()
{
	int num,fact=1;
	printf("\n enter any num");
	scanf("%d",&num);
	do
	{
	fact=fact*num;
	num=num-1;
}
while(num>0);
printf("\n fact=%d",fact);
}

