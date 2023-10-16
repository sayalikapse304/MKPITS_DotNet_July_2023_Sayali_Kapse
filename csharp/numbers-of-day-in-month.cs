using System;
namespace program
{
    class number
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Month have 31 days");
            }
            else if (num == 2)
            {
                Console.WriteLine("Month have 28 days");
            }
            else if (num == 3)
            {
                Console.WriteLine("Month have 31 days");
            }
            else if (num == 4)
            {
                Console.WriteLine("Month have 30 days");
            }
            else if (num == 5)
            {
                Console.WriteLine("Month have 31 days");
            }
            else if (num == 6)
            {
                Console.WriteLine("Month have 30 days");
            }
            else if (num == 7)
            {
                Console.WriteLine("Month have 30 days");
            }
            else if (num == 8)
            {
                Console.WriteLine("Month have 31 days");
            }
            else if (num == 9)
            {
                Console.WriteLine("Month have 30 days");
            }
            else if (num == 10)
            {
                Console.WriteLine("Month have 31 days");
            }
            else if (num == 11)
            {
                Console.WriteLine("Month have 30 days");
            }
            else if (num == 12)
            {
                Console.WriteLine("Month have 31 days");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
}

