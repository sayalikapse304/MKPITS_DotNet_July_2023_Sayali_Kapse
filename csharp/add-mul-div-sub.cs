using System;
namespace program
{
    class opration
    {
 
        public static void Main()
        {
            float num1, num2,res;

        Console.WriteLine("enter num1");
         num1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("enetr num2");
          num2 = Convert.ToInt32(Console.ReadLine());
            res = num1 + num2;
            Console.WriteLine("addition=" + res);

            res = num1 - num2;
            Console.WriteLine("substraction=" + res);

            res = num1 * num2;
            Console.WriteLine("multiplication=" + res);

            res = num1 / num2;
            Console.WriteLine("divide=" + res);

            res = num1 % num2;
            Console.WriteLine("mode=" + res);

            Console.ReadKey();
            }
}
}






