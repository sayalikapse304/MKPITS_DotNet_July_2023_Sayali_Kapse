using System;
namespace program
{
    public class shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing....");
        }
    }
    public class Rectangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
    public class Circal : shape
    {
        public override void draw()
        {

            Console.WriteLine("drawing circal");
        }
    }
    public class program
    {
        public static void Main()
        {
            shape s;
            s = new shape();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Circal();
            s.draw();
        }
    }
}
