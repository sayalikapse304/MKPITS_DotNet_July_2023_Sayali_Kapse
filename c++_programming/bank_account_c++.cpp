#include<iostream>
using namespace std;
class bank_account
{
	public:
		int account_num;
		int bal=500;
		int amt;
		int deposit()
		{
			bal=bal+amt;
			return bal;
		}
		int withdrawl()
		{
			bal=bal-amt;
			return bal;
		}
	};
	int main()
	{
		int result;
		bank_account b1;
		cout<<"enter account num"<<endl;
		cin>>b1.account_num;
		cout<<"enter amount"<<endl;
		cin>>b1.amt;
		result=b1.deposit();
		cout<<"deposit="<<result<<endl;
		result=b1.withdrawl();
		cout<<"withdrawl="<<result<<endl;
		
}
