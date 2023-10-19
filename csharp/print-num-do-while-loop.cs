using System;
namespace program
{
    class num
    {
        public static void Main()
        {
            int num = 1;
            do
            {
                Console.WriteLine("num{0}", num);
                num++;
            }
            while (num <= 5);
            Console.ReadKey();
        }
    }
}