using System;
namespace divide
{
    class div
    {
        public static void Main()
        {
            float num1, num2;
            float res;
            Console.WriteLine("enetr num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            res = num1/ num2;
            Console.WriteLine("Result=" + res);
            Console.ReadKey();
        }
    }
}
