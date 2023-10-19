using System;


namespace program
{
    class even
    {
        public static void Main()
        {

            int counter = 20;
            while (counter <= 30)
            {
                if (counter % 2 == 1)
                {
                    Console.WriteLine("{0} is odd ", counter);
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}



