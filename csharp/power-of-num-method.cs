using System;

namespace program
{
    class number
    {
        static int calculate(int num, int exponent)
        {
            int res = 1;
            int cnt;
            for (cnt = 1; cnt <= exponent; cnt++)
                res = num*res;
            Console.WriteLine("the number" + num + "to the power" + exponent +"="+res);
            return res;
        }
        static void Main(string[] args)
        {
            int number, exponent;
            Console.WriteLine("Input base number");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input exponent number");
            exponent = Convert.ToInt32(Console.ReadLine());

            int result = calculate(number, exponent);
            Console.ReadKey();
        }
    }
}