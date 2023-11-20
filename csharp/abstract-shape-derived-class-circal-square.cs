using System;
namespace program
{
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class square: Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing square...........");
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

            Shape s = new square();
            s.draw();
            s = new circal();
            s.draw();
        }
    }
}