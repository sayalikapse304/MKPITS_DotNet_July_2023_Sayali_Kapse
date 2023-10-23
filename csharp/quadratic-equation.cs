using System;

namespace program
{
    class Quadratic
    {
        public static void Main()
        {
            int a,b,c;
            float res;
            Console.WriteLine("Input the value of a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the value of b");
            b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the value of c");
            c= Convert.ToInt32(Console.ReadLine());
            res = b * b - 4 * a * c;
            Console.WriteLine("result="+res);
            if (res != 0)
            {
                Console.WriteLine("it is imaginary root");
            }
            else
            { 
                Console.WriteLine("it is real root");
            }
            Console.ReadKey();
        }
    }
}