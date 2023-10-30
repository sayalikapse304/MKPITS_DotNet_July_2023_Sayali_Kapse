using System;
using System.Runtime.Serialization.Formatters;

namespace program
{
    class method
        {
        public static void Main()
        {
            int[] arr = { 1,5,3,6,4 };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }

        }

}