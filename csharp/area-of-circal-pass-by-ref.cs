﻿using System;
namespace program
{
    class variable
    {
        static void calculate(int radius, ref float area, ref float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            float area = 0, circ = 0;
            calculate(radius, ref area, ref circ);
            Console.WriteLine("area=" + area);
            Console.WriteLine("circ=" + circ);
            Console.ReadKey();
        }
    }
}
        
            