using System;


namespace program
{
    class even
    {
        public static void Main()
        {

            int counter = 1;
            do
            {
                if (counter % 2 == 1)
                {

                    Console.WriteLine("{0} is odd", counter);
                }
                counter++;
            }
            while (counter <= 10);
            Console.ReadKey();
        }
    }
}



