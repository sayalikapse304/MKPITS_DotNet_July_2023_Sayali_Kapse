#include<string.h>
#include<stdio.h>
struct emp
{
	char empname[50];
	int salary;
};
int main()
{
	struct emp e1;
	strcpy(e1.empname,"sayali");
	e1.salary=4000;
	printf("empname=%s",e1.empname);
	printf("\n salary=%d",e1.salary);
}
