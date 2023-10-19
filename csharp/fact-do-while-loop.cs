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

            do
            {
                fact = fact * num;
                num = num - 1;
            }
            while (num > 0);
            Console.WriteLine("factorial=" + fact);
            Console.ReadKey();
        }
    }
}




