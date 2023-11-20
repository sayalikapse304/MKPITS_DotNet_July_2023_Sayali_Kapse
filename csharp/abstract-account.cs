using System;
namespace program
{
    abstract class Account
    {
        public abstract void deposit();
    }
    class saving : Account
    {
        public override void deposit()
        {
            Console.WriteLine("hello from saving deposit method");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Account acc  = new saving();
            acc.deposit();
            Console.ReadLine();
        }
    }
}
