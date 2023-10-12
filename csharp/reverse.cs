using System;
namespace program
{
    class reverse
    {
        public static void Main()
        {
            char b, a, t;
            Console.WriteLine(" enter 1st");
            b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(" enter 2nd");
            a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(" enter 3rd");
            t = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("reverse order:" + t + a + b);
            Console.ReadKey();
        }
    }
}

