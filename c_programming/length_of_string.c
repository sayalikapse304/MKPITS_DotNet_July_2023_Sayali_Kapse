#include<stdio.h>
#include<string.h>
int main()
{
	int count;
	char name[10];
	char *ptr;
	printf("\n enter name");
	gets(name);
	ptr=name;
	count=0;
	while(*ptr != '\0')
	{
	count++;
	ptr++;
}
		printf("\n length of string=%d",count);
	}
	
