using System;
namespace program
{
    class baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("hello from base class show method");
        }
    }
    class childclass : baseclass
    {
        public override void show()
        {
            Console.WriteLine("hello from child class show method");
        }
    }
    class program
    {
        static void Main()
        {
            baseclass b = new childclass();
            b.show();
            Console.ReadKey();
        }
    }
}