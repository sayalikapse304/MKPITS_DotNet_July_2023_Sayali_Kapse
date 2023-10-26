using System;
namespace program
{
    class number
    {
        public static void Main()
        {
            int number = 1;
            while (number <= 10)
            {
                Console.WriteLine(number);
                if (number == 5)
                {
                    break;
                }
                number++;
            }
            Console.ReadKey();

        }
    }
}