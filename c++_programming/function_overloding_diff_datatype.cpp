#include<iostream>
using namespace std;
class calculation
{
	public:
		int add(int n1,int n2)
		{
			return n1+n2;
		}
		float add(float n1,float n2)
		{
			return n1+n2;
		}
	};
	int main()
	{
		calculation c;
		cout<<"addition of integer no="<<c.add(2,3)<<endl;
		cout<<"addition of float no="<<c.add(3.4f,3.3f)<<endl;
		return 0;
	}

	
