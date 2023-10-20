using System;
namespace program
{
    class number
    {
        public static void Main()
        {
            int num1 = 0;
            int num2 = 1;
            int add= num1 + num2;
            Console.Write("fibonacchi series:0 1");
            for (int i = 3; i <10; i++)
            {
                Console.Write(" {0}", add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
            }
            Console.ReadKey();
        }
    }
}