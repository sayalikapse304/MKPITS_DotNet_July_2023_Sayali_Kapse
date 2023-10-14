using System;
namespace program
{
    class day
    {
        public static void Main()
        {
            int day;
            Console.WriteLine("Enter day number");
            day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Wensday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Thusday");
            }
            else if (day == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (day == 6)
            {
                Console.WriteLine("Saturday");
            }
            else
            { 
                Console.WriteLine("Sunday");
        }
        Console.ReadKey();
            }

}
 }            

            