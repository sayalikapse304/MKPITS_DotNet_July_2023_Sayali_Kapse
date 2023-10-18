using System;
namespace program
{
    class bonus
    {
        public static void Main()
        {
            int bonus=0;
            string designation;
            Console.WriteLine("enter designation manager,clerk,pron");
            designation = Console.ReadLine();
            switch (designation)
            {
                case "manager":
                    bonus = 10000;
                    break;

                case "clerk":
                    bonus = 5000;
                    break;

                case "peon":
                    bonus = 2000;
                    break;

                default:
                    Console.WriteLine("Invalid designastion");
                    break;
            }
            Console.WriteLine("bonus={0}", bonus);
            Console.ReadKey();
        }
    }
}