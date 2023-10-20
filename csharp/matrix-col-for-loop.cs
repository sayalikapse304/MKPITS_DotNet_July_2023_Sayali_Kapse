using System;
namespace program
{
    class number
    {
        public static void Main()
        {
            for (int outercounter = 1; outercounter <= 3; outercounter++)
            {
                for (int innercounter = 1; innercounter <= 3; innercounter++)
                {
                    Console.Write(innercounter + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
