using System;
namespace program
{
    abstract class shape
    {
        public abstract void draw();
    }
    class rectangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("code to draw rectange");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            shape s = new rectangle();
            s.draw();
            Console.ReadLine();
        }
    }
}
