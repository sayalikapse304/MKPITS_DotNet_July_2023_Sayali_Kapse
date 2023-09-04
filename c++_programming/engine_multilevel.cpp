#include<iostream>
using namespace std;
class Engine
{
	protected:
		string power;
		public:
			
			void start()
			{
				cout<<"car start"<<endl;
			}
			void stop()
			{
				cout<<"car stop"<<endl;
			}
		};
		class vehical
		{
			protected:
				string brand;
				public:
					void accelarator()
					{
						cout<<"accelarator"<<endl;
					}
					void car_break()
					{
						cout<<"car_break"<<endl;
					}
				void displaybrand()
				{
					cout<<"displaybrand=Nano"<<brand<<endl;
				}
			};
			class car:public Engine,public vehical
			{
			public:
				void drive()
				{
					start();
					accelarator();
					cout<<"car is driving"<<endl;
				}
				void park()
				{
				car_break();
				stop();
				cout<<"car is parking"<<endl;
			}
		};
			int main()
			{
				car c1;
				c1.displaybrand();
				c1.drive();
				c1.park();
				return 0;
			}
		
