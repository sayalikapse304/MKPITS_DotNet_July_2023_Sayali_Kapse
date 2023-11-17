using System;
namespace program
{
    class car
    {
        public void start()
        {
            Console.WriteLine("car is starting");
        }
    }
    class wagonr : car
    {
        public void startmusic()
        {
            Console.WriteLine("music is starting");
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            wagonr r = new wagonr();
            r.start();
            r.startmusic();
        }
    }

}