using System;
namespace program
{
    class number
    {
        public static void Main()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
                if (i <= 10)
                    continue;
                else
                    break;
            }
            Console.ReadKey();
        }
    }
}

              