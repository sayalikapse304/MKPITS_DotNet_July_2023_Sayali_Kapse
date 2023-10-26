using System;

namespace program
{
    class number
    {
        static int calculate(int num)
        {
            int res = 0;

            int num1 = 0;
            int num2 = 1;
            int i = 3;
            Console.WriteLine("fibonacchi series\n"+ num1+ "\n"+ num2 );
            int add = num1 + num2;
           
            
            while (i <= num)
            {
                Console.WriteLine("{0}", add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
                i++;
            }
            return res;
        }
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int result = calculate(num);
            Console.ReadKey();
        }
    }
}






