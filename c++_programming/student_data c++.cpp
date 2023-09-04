#include<iostream>
using namespace std;
class student
{
	public:
		int rollno;
		string name;
		string course;
		void getdata()
		{
			cout<<"enter roll no,name,course";
			cin>>rollno>>name>>course;
		}
		void displaydata()
		{
			cout<<"rollno=<<rollno<<endl;
			cout<<"name"<<name<<endl;
			cout<<"course"<<course<<endl;
		}
	};
	int main()
	{
		student stud1,stud2;
		cout<<"student 1"<<endl;
		stud1.getdata();
		stud1.displaydata();
		cout<<"---------------------"<<endl;
		cout<<"student2"<<endl;
		stud2.getdata();
		stud2.displaydata();
}
