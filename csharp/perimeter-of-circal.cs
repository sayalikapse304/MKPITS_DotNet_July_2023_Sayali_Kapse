using System;
namespace area
{
    class circal
    {
        public static void Main()
        {
            float radius, aoc, perimeter;
            Console.WriteLine("enter radius");
            radius = Convert.ToSingle(Console.ReadLine());

            perimeter = 2 * 3.14f * radius;
            Console.WriteLine("perimeter of circal=" + perimeter);

            aoc = 3.14f * radius * radius;
            Console.WriteLine("Area of circal=" + aoc);

            Console.ReadKey();
        }
    }
}
        