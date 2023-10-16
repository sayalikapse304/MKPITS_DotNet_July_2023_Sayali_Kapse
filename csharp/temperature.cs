using System;
using static System.Net.Mime.MediaTypeNames;

namespace program
{
    class temperature
    {
        public static void Main()
        {
            

            int temp;
            Console.WriteLine("enter temperature");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temp < 10)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Normal weather");
            }
            else if (temp < 30)
            {
                Console.WriteLine("hot weather");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("very hot weather");
            }
            Console.ReadKey();
        }
    }
}