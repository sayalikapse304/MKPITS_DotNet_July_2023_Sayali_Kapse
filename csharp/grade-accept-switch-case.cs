using System;
namespace program
{
    class grade
    {
        public static void Main()
        {
            char grade;
            Console.WriteLine("enter grade");
            grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'E':
                    Console.WriteLine("You have chosen : Excellent");
                    break;

                case 'V':
                    Console.WriteLine("You have chosen : Very Good");
                    break;

                case 'G':
                    Console.WriteLine("You have chosen : Good");
                    break;

                case 'A':
                    Console.WriteLine("You have chosen : Average");
                    break;

                case 'F':
                    Console.WriteLine("You have chosen : Fail");
                    break;

                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.ReadKey();
        }
    }
}