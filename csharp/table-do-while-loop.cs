using System;


namespace program
{
    class table
    {
        public static void Main()
        {
            int number;
            int result = 0;
            int cnt = 1;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());

            do
            {
                
                result = number * cnt;
                
                Console.WriteLine("{0}*{1}={2}", number, cnt, result);
                
                cnt++;
                
            }

            while (cnt <= 10);

            Console.ReadKey();
        }
    }
}

