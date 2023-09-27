#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string address;
	};
	class employee:public person
	{
		public:
			string designation;
			int salary;
			int empid;
		};
		int main()
		{
			employee e1;
			e1.name="sayali";
			e1.address="nagpur";
			e1.designation="maneger";
			e1.salary=555000;
			e1.empid=1233;
			cout<<e1.name<<endl<<e1.address<<endl<<e1.designation<<endl<<e1.salary<<endl<<e1.empid;
			return 0;
		}
