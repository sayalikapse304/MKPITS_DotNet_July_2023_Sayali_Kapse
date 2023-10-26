using System;

namespace program
{
    class number
    {
        static int display(string name)
        {
            int result = 0;
            return result;
        }
        static void Main(string[] args)
        {
            string nam;
            Console.WriteLine("enter name");
            nam = Console.ReadLine();
            int res = display(nam);
            Console.WriteLine("welcome friend"+ " "+nam+"!"+"\n"+"Have a nice day!");
            Console.ReadKey();
        }
    }
}