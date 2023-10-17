using System;

namespace program
{
    class height
    {
        public static void Main()
        {
            int height;
            Console.WriteLine("enter height");
           height = Convert.ToInt32(Console.ReadLine());

            if (height<150)
            {
                Console.WriteLine("It is dwarf");
            }
            else
            {
                Console.WriteLine("It is not dwarf");
            }
            Console.ReadKey();

        }
    }
}