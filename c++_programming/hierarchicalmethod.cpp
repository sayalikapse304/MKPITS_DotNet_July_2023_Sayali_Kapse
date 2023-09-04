#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;
		void getdata(int a,int b)
		{
			x=a;
			y=b;
		}
	};
	class rectangle:public shape
	{
		public:
			int crarea()
			{
				int ra;
				ra=x*y;
				return ra;
			}
		};
		class triangle:public shape
		{
			public:
			float ctarea()
			{
				float ta;
				ta=0.5*x*y;
				return ta;
			}
		};
		int main()
		{
			rectangle r;
			triangle t;
			int length,breath,height,base;
			float ta;
			int ra;
			cout<<"enter length and breath"<<endl;
			cin>>length>>breath;
			r.getdata(length,breath);
			ra=r.crarea();
			cout<<"area of rectangle="<<ra<<endl;
			cout<<"enter base and height"<<endl;
			cin>>base>>height;
			t.getdata(base,height);
			ta=t.ctarea();
			cout<<"area of triangle="<<ta<<endl;
			return 0;
}
