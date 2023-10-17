#include<stdio.h>
void calculate(int r,float*a,float*c)
{
	*a=3.14f*r*r;
	*c=2*3.14f*r;
}
int main()
{
	int radius;
	float area,circ;
	printf("\n enter radius");
	scanf("%d",&radius);
	calculate(radius,&area,&circ);
	printf("\n area=%f",area);
	printf("\n circumferance=%f",circ);
}
