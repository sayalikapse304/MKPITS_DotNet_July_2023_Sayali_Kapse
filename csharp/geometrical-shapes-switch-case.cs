using System;
namespace program
{
    class geometrical
    {
        public static void Main()
        {
            int r, l, b, choice;
            float area;
            Console.WriteLine("enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter radius");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14f * r * r;
                    Console.WriteLine("area of circal=" + area);
                    break;

                case 2:
                    Console.WriteLine("enter length");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter breath");
                    b = Convert.ToInt32(Console.ReadLine());
                    area = l * b;
                    Console.WriteLine("area of rectangal=" + area);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}