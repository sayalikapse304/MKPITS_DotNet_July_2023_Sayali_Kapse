#include<iostream>
using namespace std;
class account
{
	public:
		int actno;
		int bal;
		int interest;
		void getdata(int a,int b,int c)
		{
			actno=a;
			bal=b;
			interest=c;
		}
	};
	class saving:public account
	{
		public:
			int deposit(int amt)
			{
				bal=bal+interest+amt;
				return bal;
			}
		};
		class current:public account
		{
			public:
				int deposit(int amt)
				{
					bal=bal+amt;
					return bal;
				}
			};
			int main()
			{
				saving s;
				current c;
				int result;
				int actno,bal,interest,amount;
				cout<<"enter account details acountno,bal,interest,amt"<<endl;
				cin>>actno>>bal>>interest>>amount;
				s.getdata(actno,bal,interest);
				result=s.deposit(amount);
				cout<<"saving balance="<<result<<endl;
				c.getdata(actno,bal,interest);
				result=c.deposit(amount);
				cout<<"current balance="<<result<<endl;
				return 0;
			}

