using System;


namespace program
{
    class table
    {
        public static void Main()
        {
            int counter = 2;
            int num = 2;
            int rem = 0;



            while (num <= 20)

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
                    Console.WriteLine("prime number{0}", num);
                }
                num++;
            }
                Console.ReadLine();
            }
        }
    }