#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobno;
		void getpersondata(string n,int m)
		{
			name=n;
			mobno=m;
		}
	};
	class employee:public person
	{
		public:
			int empno;
			int salary;
			void getempdata(int e,int s)
			{
				empno=e;
				salary=s;
			}
			void displaydata()
			{
				cout<<"name:"<<name<<endl;
				cout<<"mobno:"<<mobno<<endl;
				cout<<"empno:"<<empno<<endl;
				cout<<"salary:"<<salary<<endl;
			}
		};
		int main()
		{
			employee emp;
			cout<<"enter emp detail\nname\nmobno\nempno\nsalary"<<endl;
		cin>>emp.name>>emp.mobno>>emp.empno>>emp.salary;
			emp.getpersondata(emp.name,emp.mobno);
			emp.getempdata(emp.empno,emp.salary);
			emp.displaydata();
			return 0;
		}
