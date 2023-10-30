using System;
namespace program
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int sum = 0;
            
            foreach (int val in arr)
            {
                Console.WriteLine(val);
                sum = sum + val;
            }
            Console.WriteLine("sum of array elements are " + sum);
            Console.ReadKey();
        }
    }
}