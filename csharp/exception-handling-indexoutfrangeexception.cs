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
            int[] arr = new int[3];
            arr[0] = 22;
            arr[1] = 33;
            arr[2] = 44;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("arr= " + arr[i]);
                }
            }
            catch (IndexOutOfRangeException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("finally block executing");
            }
            Console.WriteLine("bye");
        }
    }
}

