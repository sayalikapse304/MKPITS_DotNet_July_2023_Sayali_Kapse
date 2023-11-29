using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("enter number 1");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number 2");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n;
            }
            catch (Exception e)
            {
                Console.WriteLine("cannot divide by zero");
            }
            Console.WriteLine("res:" + res);
            Console.WriteLine("byy");
        }
    }
}