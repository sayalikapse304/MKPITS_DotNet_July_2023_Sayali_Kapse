#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		void deposit(int amt)
		{cout<<"hello for account deposit"<<endl;
	}
};
class saving:public Account
{
	public:
		void deposit(int amt)
		{
			int interest=500;
			bal=bal+amt+interest;
			cout<<"bal with interest is:"<<bal<<endl;
		}
	};
	class current:public Account
	{
		public:
			void deposit(int amt)
			{
				bal=bal+amt;
				cout<<"bal without interest:"<<bal<<endl;
			}
		};
		int main()
		{
			saving s;
			s.actno=1234;
			s.bal=500;
			s.deposit(100);
			current c;
			c.actno=123;
			c.bal=1000;
			c.deposit(500);
			return 0;
		}
		
