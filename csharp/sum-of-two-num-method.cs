using System;

namespace program
{
    class number
    {
        static int calculate(int num1, int num2)
        {
            int res = 0;
            res = num1 + num2;
            return res;
        }
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("enter number1");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number2");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = calculate(number1, number2);
            Console.WriteLine("The sum of two numbers is:" + result);
            Console.ReadKey();
        }
    }
}