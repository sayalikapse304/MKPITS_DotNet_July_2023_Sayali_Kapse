using System;
namespace print
{
    class program
    {
        public static void Main(string[] args)
        {
            int num;
            Console.Write("Enter num 1: ");
            num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            
            int res;

            while(i <= 10)
            {
                int j = 1;
                while (j <= num)
                {
                    res = i * j;
                    Console.Write("{0}*{1}={2} ", j, i, res);
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadKey();
        }
    }
}