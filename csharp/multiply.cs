﻿using System;
namespace multiplication
{
    class mul
    {
        public static void Main()
        {
            int num1, num2, num3, mul;

            Console.WriteLine("enetr num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr num3");
            num3 = Convert.ToInt32(Console.ReadLine());

            mul = num1 * num2 * num3;
            Console.WriteLine("2*3*6=" + mul);
            Console.ReadKey();
        }
    }
}
