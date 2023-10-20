using System;
namespace program
{
    class number
    {
        public static void Main()
        {

            for (int outercounter = 1; outercounter <= 3; outercounter++)
            {
                for (int innercounter = 1; innercounter <= outercounter; innercounter++)

                {
                    Console.Write(innercounter +"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
