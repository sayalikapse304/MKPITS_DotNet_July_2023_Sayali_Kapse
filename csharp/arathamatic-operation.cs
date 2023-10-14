using System;
using System.Xml.Serialization;

namespace program
{
    class arithamatic
    {
        public static void Main()
        {
            int num1, num2, choice;
            float res = 0;
            Console.WriteLine("enter choice");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                res = num1 + num2;
                Console.WriteLine("addition=" + res);
            }
            else if (choice == 2)
            {
                res = num1 - num2;
                Console.WriteLine("substraction=" + res);
            }
            else if (choice == 3)
            {
                res = num1 * num2;
                Console.WriteLine("Multiplication=" + res);
            }
            else if (choice == 4)
            {
                res = num1 / num2;
                Console.WriteLine("Division=" + res);
            }
            Console.ReadKey();
        }
    }
}