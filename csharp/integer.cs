using System;

namespace program
{
    class integer
    {
        public static void Main()
        {
            int m;
            Console.WriteLine("enter num");
            m = Convert.ToInt32(Console.ReadLine());

            if (m>0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.ReadKey();

        }
    }
}