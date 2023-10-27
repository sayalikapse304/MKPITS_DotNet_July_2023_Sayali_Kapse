using System;
namespace program
{
    class variable
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            num[0] = 11;
            num[1] = 22;
            num[2] = 33;
            Console.WriteLine("num[0]=" + num[0]);
            Console.WriteLine("num[1]=" + num[1]);
            Console.WriteLine("num[2]=" + num[2]);
            Console.ReadKey();
        }
    }
}