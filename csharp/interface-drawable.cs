using System;
namespace program
{
    interface Drawable
    {
        void draw();
    }
    class circal : Drawable
    {
        public void draw()
        {
            Console.WriteLine("circal drwing");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Drawable d = new circal();
            d.draw();
            Console.ReadKey();
        }
    }
}
