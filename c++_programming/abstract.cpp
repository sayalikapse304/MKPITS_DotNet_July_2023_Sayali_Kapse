#include<iostream>
using namespace std;
class student
{
	public:
		virtual void rollno()=0;
		virtual void name()=0;
		virtual void cls()=0;
	};
	class stu1:public student
	{
		public:
			void rollno()
			{
				cout<<"roll no"<<endl;
			}
			void name()
			{
				cout<<"name"<<endl;
			}
			void cls()
			{
				cout<<"cls"<<endl;
			}
			};
			int main()
			{
				stu1 s;
				s.rollno();
				s.name();
				s.cls();
				return 0;
			}

