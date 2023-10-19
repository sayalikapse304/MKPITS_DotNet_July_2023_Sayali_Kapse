using System;
namespace program
{
    class number
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;

                case 4:
                    Console.WriteLine("Four");
                    break;

                case 5:
                    Console.WriteLine("Five");
                    break;

                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
            Console.ReadKey();
        }
    }
}