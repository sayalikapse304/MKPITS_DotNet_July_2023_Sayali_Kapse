#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		virtual void deposit(int amt)=0;
	};
	class saving:public Account
	{
		public:
			void deposit(int amt)
			{
				int interest=500;
				bal=bal+amt+interest;
				cout<<"bal with interest"<<bal<<endl;
			}
		};
		class current:public Account
		{
			void deposit(int amt)
			{
				bal=bal+amt;
				cout<<"bal without interest"<<bal<<endl;
			}
		};
		int main()
		{
			Account *acc;
			saving s;
			current c;
			acc=&s;
			acc->actno=2233;
			acc->bal=500;
			acc->deposit(200);
			acc=&c;
			acc->actno=234;
			acc->bal=300;
			acc->deposit(100);
			return 0;
		}
		
