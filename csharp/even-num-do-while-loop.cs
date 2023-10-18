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
                if (counter % 2 == 0)
                {

                    Console.WriteLine("{0} is even ", counter);
                }
                counter++;
            }
            while (counter <= 10);
            Console.ReadKey();
        }
    }
}



