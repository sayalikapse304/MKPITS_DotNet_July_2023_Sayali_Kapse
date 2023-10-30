using System;
namespace program
{
    class method
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4 };
            int[] arr1 = new int[4];
            Array.Copy(arr,arr1, 4);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadLine();
        }
    }

}