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
                int n = arr[arr.Length - 2];
                Console.WriteLine("the seconde largest element is:" + n);
            
                Console.ReadKey();
            }
        }
    }