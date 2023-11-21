using System;
namespace program
{
    public interface shape
    {
        public void draw();
    }
    public class rectangle : shape
    {
        public void draw()
        {
            Console.WriteLine("Draw method of rectange class");
        }
    }
    public class circle : shape
    {
        public void draw()
        {
            Console.WriteLine("Draw method of circle class");
        }
    }
    public class program
    {
        public static void Main(string[] args)
        {
            shape s = new rectangle();
            s.draw();

            s = new circle();
            s.draw();
            Console.ReadKey();
        }
    }


}