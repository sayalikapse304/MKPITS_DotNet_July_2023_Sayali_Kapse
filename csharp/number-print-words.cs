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
                Console.WriteLine("One");
            }
            else if (digit == 2)
            {
                Console.WriteLine("Two");
            }
            else if (digit == 3)
            {
                Console.WriteLine("Three");
            }
            else
            {
                Console.WriteLine("Invalid digit");
            }
            Console.ReadKey();
        }
    }
}
        