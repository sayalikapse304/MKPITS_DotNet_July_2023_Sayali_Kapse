using System;


namespace program
{
    class number
    {
        static int table(int num)
        {
            int res = 0;
            int cnt = 1;
            while (cnt <= 10)
            {
                
                res = num * cnt;
                Console.WriteLine(res);
                cnt++;
            }
            return res;
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            int result = table(number);
          
            Console.ReadKey();
        }
    }
}
