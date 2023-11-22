using System;
namespace first
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("Hellow first namespace");
        }
    }
}
namespace second
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("Hellow second namespace");
        }
    }
}
public class program
{
    static void Main(string[]args)
    {
        first.Hello h1 = new first.Hello();
        second.Hello h2 = new second.Hello();
        h1.sayHello();
        h2.sayHello();


    }
}

