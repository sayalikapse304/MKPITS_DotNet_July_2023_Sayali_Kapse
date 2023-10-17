#include<iostream>
using namespace std;
class Game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
};
class Tic_Tac_Toe:public Game
{
	public:
	void start()
	{
		cout<<"start Tic_Tac_Toe game"<<endl;
	}
	void play()
	{
		cout<<"play Tic_Tac_Toe game"<<endl;
	}
	void end()
	{
		cout<<"end Tic_Tac_Toe game"<<endl;
	}
};
class chease:public Game
{
	public:
	void start()
	{
		cout<<"start chease game"<<endl;
	}
	void play()
	{
		cout<<"play chease game"<<endl;
	}
	void end()
	{
		cout<<"end chease game"<<endl;
	}
};
	int main()
	{
		Tic_Tac_Toe t;
		t.start();
		t.play();
		t.end();
		cout<<"-------------------------"<<endl;
		chease c;
		c.start();
		c.play();
		c.end();
		return 0;
	}

