#include<stdio.h>
void main()
{
	int pin,with,bal,deposit,ch,newpin,amt;
	printf("\n*** Welcome to SBI ATM ***");
	printf("\n ---------------------------------------------------------------");
	printf("\npress:\n 1==>Deposit\n 2==>Withdraw\n 3==>Balance\n 4==>change pin");
	scanf("%d",&ch);
	bal=1000;
	switch(ch)
	{
		case 1:
			printf("\n Deposit");
			printf("\nenter pin");
			scanf("%d",&pin);
			if(pin==143)
			{
				printf("\n enter amount to deposit");
				scanf("%d",deposit);
				bal=bal+deposit;
				printf("\n amount deposit successfully");
				printf("\n Available balance:%d",bal);
			}
			else
			{
				printf("\n Invalid pin");
			}
			break;
			case 2:
				printf("\n Withdraw");
				printf("\n eneter pin");
				scanf("%d",&pin);
				if(pin==143)
				{
					printf("\n enter amount to withdraw");
					scanf("%d",&with);
					bal=bal-with;
					printf("\n amout withdraw successfully");
					printf("\n available balance:%d",bal);
				}
				else
				{
					printf("\n Invalid pin");
				}
					break;
					case 3:
						printf("\n balance enquiry");
						printf("\n enter pin");
						scanf("%d",&pin);
						if(pin==143)
						{
							printf("\n Available balance:%d",bal);
						}
						else
						{
							printf("\n Invalid pin");
						}
						break;
						case 4:
							printf("\n pin changed");
							printf("\n enter old pin");
							scanf("%d",&pin);
							if(pin==143)
							{
								printf("\n enter new pin");
								scanf("%d",&newpin);
								printf("\n pin changed successfully");
							}
							else
							{
								printf("\n Invalid pin");
							}
							break;
							default:
								printf("\n Invalid choice");
							}
						}
