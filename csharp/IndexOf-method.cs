using System;
namespace program
{
    class method
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3 };
            int l = Array.IndexOf(arr, 3);
            Console.WriteLine("Index of 3 is=" + l);

            Console.ReadKey();

        }
    }
}