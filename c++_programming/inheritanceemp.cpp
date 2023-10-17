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
		void getdata()
		{
			cout<<"enter name,address,designation,salary,empid";
			cin>>name>>address>>designation>>salary>>empid;
		}
		void display()
		{
			cout<<"name:"<<name<<endl;
			cout<<"address:"<<address<<endl;
			cout<<"designation:"<<designation<<endl;
			cout<<"salary:"<<salary<<endl;
			cout<<"empid:"<<empid<<endl;
		}
		};
		int main()
		{
			employee e1;
			e1.getdata();
			e1.display();
			return 0;			
		}
