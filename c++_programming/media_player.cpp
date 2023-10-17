#include<iostream>
using namespace std;
class Media_player
{
	public:
		virtual void play()=0;
		virtual void paus()=0;
		virtual void stop()=0;
};
	class Audio_player:public Media_player
	{
		public:
			void play()
			{
				cout<<"play audio player"<<endl;
			}
			void paus()
			{
				cout<<"paus audio player"<<endl;
			}
			void stop()
			{
				cout<<"stop audio player"<<endl;
			}
		};
		class video_player:public Media_player
	{
		public:
			void play()
			{
				cout<<"play video player"<<endl;
			}
			void paus()
			{
				cout<<"paus video player"<<endl;
			}
			void stop()
			{
				cout<<"stop video player"<<endl;
			}
		};
		int main()
		{
			Audio_player a;
			a.play();
			a.paus();
			a.stop();
			cout<<"------------------------"<<endl;
			video_player v;
			v.play();
			v.paus();
			v.stop();
			return 0;
		}
		
