using System;

namespace program
{
    class number
    {
        static int calculate(int number1, int number2)
        {
            int res = 0;
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("now the 1st number is:" + number1 + "," + "and the 2nd number is:" + number2);
            return res;
        }
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("enter number 1");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number 2");
            number2 = Convert.ToInt32(Console.ReadLine());

            

            int result = calculate(number1, number2);
            
            Console.ReadKey();
        }
    }
}



