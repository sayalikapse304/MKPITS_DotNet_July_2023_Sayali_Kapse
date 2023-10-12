using System;
namespace program
{
    class avarage
    {

        public static void Main()
        {
            int num1, num2, num3, num4, tot;
            float avr;
            Console.WriteLine("enter number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number3");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number4");
            num4 = Convert.ToInt32(Console.ReadLine());
            tot = num1 + num2 + num3 + num4;
            avr = tot / 4;
            Console.WriteLine("the avarage :" + avr);
            Console.ReadKey();
        }
    }
}