using System;
namespace program
{
    interface shape
    {
        void draw();
    }
    class rectangle : shape
    {
        public void draw()
        {
            Console.WriteLine("Draw method of rectange class");
        }
    }
    class circle: shape
    {
        public void draw()
        {
            Console.WriteLine("Draw method of circle class");
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            shape s = new rectangle();
            s.draw();

            s = new circle();
            s.draw();
            Console.ReadKey();
        }
    }


}