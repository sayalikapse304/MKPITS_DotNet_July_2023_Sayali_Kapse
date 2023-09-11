#include<stdio.h>
void deposit(int amt,int bal);
void withdrawl(int amt,int bal);
int main()
{
	int amt,bal=1000;
	printf("\n enter amount");
	scanf("%d",&amt);
	deposit(amt,bal);
	withdrawl(amt,bal);
}
void deposit(int amt,int bal)
{
	bal=bal+amt;
	printf("\n amount deposit bal is %d",bal);
}
void withdrawl(int amt,int bal)
{
	bal=bal-amt;
	printf("\n amount withdrawl bal is %d",bal);
	}
