using System;
namespace program
{
    class number
    {
        public static void Main()
        {
            int digit;
            Console.WriteLine("Enter digit");
            digit = Convert.ToInt32(Console.ReadLine());

            if (digit == 1)
            {
                Console.WriteLine("Janwary");
            }
            else if (digit == 2)
            {
                Console.WriteLine("Februawary");
            }
            else if (digit == 3)
            {
                Console.WriteLine("March");
            }
            else
            {
                Console.WriteLine("Invalid Month");
            }
            Console.ReadKey();
        }
    }
}
