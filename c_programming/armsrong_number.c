#include<stdio.h>
int main()
{
	int num,res=0,sum=0,i;
	printf("\n enter no");
	scanf("%d",&num);
	for(res=num;num!=0;num=num/10)
	{
		i=num%10;
		
			sum=sum+i*i*i;
		}
		if(sum==res)
		printf("%d is armstrong number\n",res);
		else
		printf("%d is not a armstrong number\n",res);
	}

