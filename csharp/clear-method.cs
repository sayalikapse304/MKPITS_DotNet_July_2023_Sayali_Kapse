using System;
namespace program
{
    class method
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4 };
            Array.Clear(arr, 0, 3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
        }
    
}