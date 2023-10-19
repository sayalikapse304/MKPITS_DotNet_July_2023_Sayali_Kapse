using System;


namespace program
{
    class even
    {
        public static void Main()
        {
            
            int counter = 1;
            while (counter <= 10)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("{0} is even ", counter);
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}



