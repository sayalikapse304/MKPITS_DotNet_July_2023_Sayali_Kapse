#include<iostream>
using namespace std;
class car
{
	public:
		string make;
		string model;
		int year;
		void startEngine()
		{
			cout<<"engine started"<<endl;
		}
		void brake()
		{
			cout<<"brak applid"<<endl;
		}
	};
	int main()
	{
		car c1;
		c1.make="\tmaruti";
		c1.model="\tsuv";
		c1.year=2022;
		cout<<"make"<<c1.make<<endl;
		cout<<"model"<<c1.model<<endl;
		cout<<"year"<<c1.year<<endl;
		c1.startEngine();
		c1.brake();
		return 0;
}
