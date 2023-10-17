using System;
namespace program
{
    class greater
    {
        public static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter 3 Numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("num1 is greter");
            else if (num2 > num3)
                Console.WriteLine("num2 is greter");
            else
                Console.WriteLine("num3 is greter");
            Console.ReadKey();
        }
    }
}