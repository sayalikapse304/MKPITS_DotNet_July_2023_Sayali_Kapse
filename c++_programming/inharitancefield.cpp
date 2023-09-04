#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string city;
	};
	class student:public person
	{
		public:
			int rno;
			int marks;
		};
		int main()
		{
			student s1;
			s1.name="sayali\n";
			s1.city="banglore\n";
			s1.rno=22;
			s1.marks=800;
			cout<<s1.name<<s1.city<<s1.rno<<endl<<s1.marks;
			return 0;
		}
