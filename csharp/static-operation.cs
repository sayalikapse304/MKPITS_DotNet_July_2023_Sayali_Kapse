using System;
using System.ComponentModel;

namespace program
{
    static class MathOperation
    {
        public static int add(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("addition:" + MathOperation.add(5, 4));
            Console.WriteLine("multiplication:" + MathOperation.multiply(5, 4));

            Console.ReadKey();

        }
    }
}


