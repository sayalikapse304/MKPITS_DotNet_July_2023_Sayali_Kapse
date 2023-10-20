using System;
namespace program
{
    class number
    {
        public static void Main()
        {
            for (int i = 0, j=0; i<= 5; i++, j++)
            {
                Console.WriteLine("i=" + i);
                Console.WriteLine("j=" + j);
            }
            Console.ReadKey();
        }
    }
}