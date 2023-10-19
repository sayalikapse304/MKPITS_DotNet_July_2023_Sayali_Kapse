using System;
namespace program
{
    class month
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("januawary");
                    break;

                case 2:
                    Console.WriteLine("februwari");
                    break;

                case 3:
                    Console.WriteLine("march");
                    break;

                case 4:
                    Console.WriteLine("april");
                    break;

                case 5:
                    Console.WriteLine("may");
                    break;

                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
            Console.ReadKey();
        }
    }
}