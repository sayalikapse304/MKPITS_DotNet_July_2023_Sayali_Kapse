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

            while (num > 0)
            {
                fact = fact * num;
                num = num - 1;
            }
            Console.WriteLine("factorial=" + fact);
            Console.ReadKey();
        }
    }
}
           



