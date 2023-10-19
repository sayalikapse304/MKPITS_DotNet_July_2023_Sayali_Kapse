using System;


namespace program
{
    class prime
    {
        public static void Main()
        {
            int num;
            int counter = 2;
            int rem = 0;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            while (counter < num)
            {
                if (num % counter == 0)
                {
                    rem = 1;
                    break;
                }
                counter++;
            }
            if (rem == 0)
            {
                Console.WriteLine("num is prime");
            }
            else
            {
                Console.WriteLine("num is not prime");
            }
            Console.ReadKey();
        }
    }

            }
