using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("enter element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            int n = arr.Length;
            Console.WriteLine("the seconde smallest element is:" + arr[1]);

            Console.ReadKey();
        }
    }
}