using System;
namespace program
{
    class number
    {
        public static void Main()
        {
            int num;
            int sum = 0;
            for (int cnt = 1; cnt <= 5; cnt++)
            {
                Console.WriteLine("enter number");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("sum of no.=" + sum);
            Console.ReadKey();
        }
    }
}