using System;
namespace program
{
    class  operation
    {
        public static void Main()
        {
            int choice,num1,num2;
            float res;
            Console.WriteLine("enter your choice 1 for addition");
            Console.WriteLine("enter your choice 2 for substraction");
            Console.WriteLine("enter your choice 3 multiplication");
            Console.WriteLine("enter your choice 4 division");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

           

            switch (choice)
            {
                case 1:
                    res = num1 + num2;
                    Console.WriteLine("addition="+res);
                    break;

                case 2:
                    res = num1 - num2;
                    Console.WriteLine("substraction="+res);
                    break;

                case 3:
                    res = num1 * num2;
                    Console.WriteLine("Multiplication=" + res);
                    break;

                case 4:
                    res = num1 / num2;
                    Console.WriteLine("Division=" + res);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}