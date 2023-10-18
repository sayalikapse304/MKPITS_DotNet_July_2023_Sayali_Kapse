using System;
namespace program
{
    class vowel
    {
        public static void Main()
        {
            int dayno;
            Console.WriteLine("enter day number");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch (dayno)
            {
                case 1:

                    Console.WriteLine("Monday");
                    break;

                case 2:

                    Console.WriteLine("Tuesday");
                    break;

                case 3:

                    Console.WriteLine("wensday");
                    break;

                case 4:

                    Console.WriteLine("Thusday");
                    break;

                case 5:

                    Console.WriteLine("friday");
                    break;

                case 6:

                    Console.WriteLine("saturday");
                    break;

                case 7:

                    Console.WriteLine("sunday");
                    break;

                default:

                    Console.WriteLine("Invalid day number");
                    break;
            }
            Console.ReadKey();
        }
    }
}