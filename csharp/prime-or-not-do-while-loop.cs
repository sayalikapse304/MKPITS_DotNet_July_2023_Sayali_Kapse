using System;


namespace program
{
    class prime
    {
        public static void Main()
        {
            int num = 3;
            int counter = 2;
            int rem = 0;
            Console.Write("Prime no. is: 2 ");
           
            do
            {
                rem = 0;
                counter = 2;

                while (counter < num)
                {
                    if (num % counter == 0)
                    {
                        rem = 1;
                        break;
                    }
                    counter++;
                }

                if (rem == 0)
                {
                    Console.Write(" {0} ", num);
                }
                num++;
                
            }

            while (num <= 20);
                Console.ReadKey();
        }
    }

}
