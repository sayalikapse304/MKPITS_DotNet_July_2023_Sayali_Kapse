#include<iostream>
using namespace std;
int main()
{
	int i,arr1[5],arr2[5];
	for(i=0;i<5;i++)
	{
		cout<<"\n enter num";
		cin>>arr1[i];
	}
	for(i=0;i<5;i++)
	{
		arr2[i]=arr1[i];
	}
	cout<<"element of arr1\n";
	for(i=0;i<5;i++)
	cout<<arr1[i]<<endl;
cout<<"element of arr2\n";
    for(i=0;i<5;i++)
    cout<<arr2[i]<<endl;
		return 0;
}

    
