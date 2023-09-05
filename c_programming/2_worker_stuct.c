#include<stdio.h>
struct worker
{
	char name[50];
	int wage;
	int wdays;
};
int main()
{
	struct worker w1,w2;
	printf("\n enter details of 1st worker\n ");
	printf("\n enter worker name:");
	scanf("%s",w1.name);
	printf("\n enter wage:");
	scanf("\n %d",&w1.wage);
	printf("\n eneter working days:");
	scanf("%d",&w1.wdays);
	printf("..................................\n");
	printf("\n enter details of 2nd worker\n ");
	printf("\n enter worker name:");
	scanf("%s",w2.name);
	printf("\n enter wage:");
	scanf("\n %d",&w2.wage);
	printf("\n eneter working days:");
	scanf("%d",&w2.wdays);
	printf(".....................................\n");
int	p1=w1.wage*w1.wdays;
	printf("name of 1st worker:%s\npayment of 1st worker:%d\n",w1.name,p1);
	printf(".......................................\n");
int	p2=w2.wage*w2.wdays;
		printf("name of 2nd worker:%s\npayment of 2nd worker:%d\n",w2.name,p2);
}
