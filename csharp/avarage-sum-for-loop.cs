using System;
namespace program
{
    class natural
    {
        public static void Main()
        {
            int num, res = 0;

            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int cnt = 1; cnt <= num; cnt++)
            {
                res = cnt * cnt * cnt;

                Console.WriteLine("number is:{0}and cube of the {1} is :{2}\n",cnt,cnt, res);
            }
            Console.ReadKey();
        }
    }
}