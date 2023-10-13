using System;
namespace squareprogram
{
    class square
    {
        public static void Main()
        {
            int num, sqr;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            sqr = num * num;
            Console.WriteLine("squar=" + sqr);
            Console.ReadKey();
        }
    }
}


   
