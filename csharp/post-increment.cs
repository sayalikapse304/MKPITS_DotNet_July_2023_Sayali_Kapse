using System;
namespace program
{
    class postincrement
    {
        public static void Main()
        {
            int i = 0;
            int j = i++;
            Console.WriteLine("Value of i:" + i + " value of j:" + j);
            Console.ReadKey();
        }
    }
}