using System;
namespace program
{
    class geometry
    {
        public static void Main()
        {
            float r, l, b,w, h;
            float area;
            int choice;

            Console.WriteLine("enter Choice");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("enter radius");
                r = Convert.ToInt32(Console.ReadLine());
                area = 3.14f*r*r;
                Console.WriteLine("area of circal=" + area);
            }
            else if (choice == 2)
            {
                Console.WriteLine("enter length");
                l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter breath");
                w = Convert.ToInt32(Console.ReadLine());
                area = l * w;
                Console.WriteLine("area of Rectangal=" + area);
            }
            else if (choice == 3)
            {
                Console.WriteLine("enter base");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter height");
                h = Convert.ToInt32(Console.ReadLine());
                area = 1/2 * (b * h); 
                Console.WriteLine("area of triangal =" + area);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
}


           