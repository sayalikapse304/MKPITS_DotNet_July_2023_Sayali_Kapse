using System;
namespace program
{
    class number
    {
        static void factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("factorial=" + fact);
        }
        static void Main(string[] args)
        {
            factorial(5);
            Console.ReadKey();
        }
    }
}