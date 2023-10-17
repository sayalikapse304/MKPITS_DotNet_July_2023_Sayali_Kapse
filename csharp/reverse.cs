using System;
namespace program
{
    class reverse
    {
        public static void Main()
        {
            char b, a, t;
            Console.WriteLine(" enter 1st letter");
            b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(" enter 2nd letter");
            a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(" enter 3rd letter");
            t = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("reverse order:" + t + a + b);
            Console.ReadKey();
        }
    }
}

