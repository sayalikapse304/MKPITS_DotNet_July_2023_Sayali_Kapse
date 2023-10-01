#include<iostream>
using namespace std;
class rectangle
{
	public:
		int length;
		int width;
		float calculateArea()
		{
			float a=length*width;
			return a;
		}
		float calculateParameter()
		{
			float parameter=2*length+width;
			return parameter;
		}
	};
	int main()
	{
		float result;
		rectangle r1;
		cout<<"enter length and width";
		cin>>r1.length>>r1.width;
		result=r1.calculateArea();
		cout<<"area="<<result<<endl;
		result=r1.calculateParameter();
		cout<<"parameter="<<result;
}
