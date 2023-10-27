using System;
namespace program
{
    class variable
    {
        static void display(int num)
        {
            num = 20;
            Console.WriteLine("num inside method=" + num);
        }
        static void Main(string[] args)
        {
            int num = 10;
            display(num);
            Console.WriteLine("num after passing inside main=" + num);
            Console.ReadKey();
        }

    }
}