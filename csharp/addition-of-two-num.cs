﻿using System;
namespace addition
{
    class add
    {
        public static void Main()
        {
            int num1, num2, add;
            Console.WriteLine("enetr num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine("Result=" + add);
            Console.ReadKey();
        }
    }
}