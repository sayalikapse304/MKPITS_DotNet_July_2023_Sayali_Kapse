using System;
namespace program
{
    class number
    {
        static int calculate(int num1, int num2, char op)
        {
            int res = 0;
            if (op == '+')
                res = num1 + num2;
            else if (op == '-')
                res = num1 - num2;

            else if (op == '*')
                res = num1 * num2;
            else
                Console.WriteLine("Invalid operator");
            return res;
        }
        static void Main(string[]args)
        {
            int number1, number2;
            char oper;
            Console.WriteLine("Enter number 1");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter + - *");
            oper = Convert.ToChar(Console.ReadLine());

            int res = calculate(number1, number2, oper);
            Console.WriteLine("result=" + res);
            Console.ReadKey();
        
            
        }
    }
}