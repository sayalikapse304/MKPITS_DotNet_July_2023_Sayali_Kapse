#include<stdio.h>
#include<string.h>
int main()
{
	char str1[100],str2[100];
	char *p1,*p2;
	printf("\n enter the string");
	gets(str1);
	p1=str1+strlen(str1)-1;
	p2=str2;
	while(p1>=str1)
	{
		*p2=*p1;
		p2++;
		p1--;
	}
	*p2='\0';
	printf("orignal string:%s\n",str1);
	printf("revers string:%s\n",str2);
	}
