using System;
namespace program
{
    class variable
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int flag = 0;
            int usernum;
            Console.WriteLine("enetr number to the serched");
            usernum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == usernum)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("num {0} is found in an array", usernum);
            }
            else
            {
                Console.WriteLine("number is not found in an arrray");
            }
            Console.ReadKey();
        }
    }
}