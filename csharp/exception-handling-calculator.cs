using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Calculator
    {
        public double Result { get; set; }
        public void Add(double num)
        {
            Result += num;
        }
        public void Subtract(double num)
        {
            Result -= num;
        }
        public void Multiply(double num)
        {
            Result *= num;
        }
        public void Division(double num)
        {
            if (num != 0)
            {
                Result /= num;
            }
            else
            {
                Console.WriteLine("Error:cannot divide by zero");
            }
        }

        public void Exponentiate(double exponent)
        {
            Result = Math.Pow(Result, exponent);
        }
        public void SquareRoot()
        {
            if (Result >= 0)
            {
                Result = Math.Sqrt(Result);
            }
            else
            {
                Console.WriteLine("Error:cannot calculate squre root of negative number");
            }
        }
        public void clear()
        {
            Result = 0;
        }
    }

    class program
    {
        static void Main()
        {
            Calculator cal = new Calculator();
            while (true)
            {
                Console.WriteLine("current result:" + cal.Result);
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Subtract");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Divide");
                Console.WriteLine("5.Exponentiate");
                Console.WriteLine("6.square root");
                Console.WriteLine("7.clear");
                Console.WriteLine("0.Exit");

                Console.WriteLine("Enter your choice:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter number to add");
                        double addnum = Convert.ToDouble(Console.ReadLine());
                        cal.Add(addnum);
                        break;

                    case "2":
                        Console.WriteLine("Enter number to subtract");
                        double subnum = Convert.ToDouble(Console.ReadLine());
                        cal.Subtract(subnum);
                        break;

                    case "3":
                        Console.WriteLine("Enter number to Multiply");
                        double mulnum = Convert.ToDouble(Console.ReadLine());
                        cal.Multiply(mulnum);
                        break;

                    case "4":
                        Console.WriteLine("Enter number to divide");
                        double divnum = Convert.ToDouble(Console.ReadLine());
                        cal.Division(divnum);
                        break;

                    case "5":
                        Console.WriteLine("Enter number to exponent");
                        double expnum = Convert.ToDouble(Console.ReadLine());
                        cal.Exponentiate(expnum);
                        break;

                    case "6":

                        cal.SquareRoot();
                        break;

                    case "7":

                        cal.clear();
                        break;

                    case "0":
                        Console.WriteLine("exiting the calculator");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.Please try again.");
                        break;
                }
                Console.WriteLine();



            }
        }
    }
}
    





            