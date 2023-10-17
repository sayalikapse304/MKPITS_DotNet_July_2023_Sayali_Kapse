using System;
namespace program
{
    class triangle
    {
        public static void Main()
        {
            int sidep, sideq, sider;
            Console.Write(" side 1 of triangle: ");
            sidep = Convert.ToInt32(Console.ReadLine());

            Console.Write(" side 2 of triangle: ");
            sideq = Convert.ToInt32(Console.ReadLine());

            Console.Write("side 3 of triangle: ");
            sider = Convert.ToInt32(Console.ReadLine());



            if (sidep == sideq && sideq == sider)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (sidep == sideq || sidep == sider || sideq == sider)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }
                Console.ReadKey();

            }
    }
}