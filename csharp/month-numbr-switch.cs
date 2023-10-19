using System;
namespace program
{
    class month
    {
        public static void Main()
        {
            int month;
            Console.WriteLine("enter month");
            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    Console.WriteLine("Month have 31 days");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:

                    Console.WriteLine("Month have 29 days");
                    break;


                case 2:

                    Console.WriteLine("Month have 28 days");
                    break;

                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }
            Console.ReadKey();
        }
    }
}