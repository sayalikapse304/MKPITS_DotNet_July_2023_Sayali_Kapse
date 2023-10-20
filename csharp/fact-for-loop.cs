using System;


namespace program
{
    class number
    {
        public static void Main()
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int cnt = num; cnt > 0; cnt--)
            {
                fact = fact * cnt;
            }
            Console.WriteLine("fact=" + fact);
            Console.ReadKey();
        }
    }
}