﻿using System;
namespace circumference
{
    class area
    {
        public static void Main()
        {
            int radius;
            float area, circ;
            Console.WriteLine("enetr radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
            Console.WriteLine("area of circal=" + area);
            Console.WriteLine("area of circ=" + circ);
            Console.ReadKey();
        }
    }
}