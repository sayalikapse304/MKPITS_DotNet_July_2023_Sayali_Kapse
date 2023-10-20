using System;
namespace program
{
    class natural
    {
        public static void Main()
        {
            int sum = 0;


            for (int cnt = 1; cnt <= 10; cnt++)
            {
                Console.WriteLine("naturals number are:" + cnt);
                sum = sum + cnt;
            }
            Console.WriteLine("sum of natural number are:" + sum);
            Console.ReadKey();
        }
    }
}