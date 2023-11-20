using System;
namespace program
{
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing rectangle...........");
        }
    }
    public class circal : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing circal...........");
        }
    }
    public class program
    {
        public static void Main(string[] args)
        {

            Shape s = new rectangle();
            s.draw();
            s = new circal();
            s.draw();
        }
    }
}