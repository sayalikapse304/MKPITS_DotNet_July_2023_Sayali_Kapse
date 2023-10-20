using System;
namespace program
{
    class natural
    {
        public static void Main()
        {
            int num;
            
            Console.WriteLine("enter limit");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write("{0}*{1}={2}", i, j,(i * j));
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
               