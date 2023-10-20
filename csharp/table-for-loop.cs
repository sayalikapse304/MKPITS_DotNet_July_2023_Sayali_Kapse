using System;
namespace program
{
    class table
    {
        public static void Main()
        {
            int num;
            int res = 0;
            int cnt;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());

            for (cnt = 1; cnt <= 10;cnt++)
            {
                res = num * cnt;

                Console.WriteLine("{0}*{1}={2}", num, cnt, res);
            }
            
            Console.ReadKey();
        }
    }
}
                

   
