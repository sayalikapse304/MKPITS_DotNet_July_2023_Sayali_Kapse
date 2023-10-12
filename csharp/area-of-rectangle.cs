using System;
namespace rectangle
{
    class area
    {
        public static void Main()
        {
            int length,breadth,result;
            Console.WriteLine("enetr length");
            length= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
            result = length * breadth;
            Console.WriteLine("area of rectangle=" +result);
            Console.ReadKey();
        }
    }
}