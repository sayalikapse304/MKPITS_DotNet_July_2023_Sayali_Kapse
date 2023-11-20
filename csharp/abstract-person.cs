using System;
namespace program
{
    abstract class Person
    {
        public abstract void display();
        public void showdata()
        {
            Console.WriteLine("hello from showdata");
        }

    }
    class student : Person
    {
        public override void display()
        {
            Console.WriteLine("hello from disply method");
        }

    }

    class program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.display();
            s.showdata();
            Console.ReadKey();
        }
    }
}
      