using System;
namespace program
{
    class price
    {
        public static void Main()
        {
            int c, s, res;
            Console.WriteLine("Enter cost price");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter selling price");
            s= Convert.ToInt32(Console.ReadLine());
            if(s>c)
            {
                res = s - c;
                Console.WriteLine("You can book your profit amount :" + res);
            }
            else
            {
                res = c - s;
                Console.WriteLine("You can book your loss amount :" + res);

            }
            Console.ReadKey();
        }
    }
}