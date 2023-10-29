using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace program
{
    class num
    {
        public static void Main()
        {
            int cnt = 0;

            int[] arr1 = new int[3];

            Console.WriteLine("Input the number of element to store in the array:3");
            Console.WriteLine("Input 3 number of element  in the array");

            for (int i = 0; i < 3; i++)
            {

                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("element-{0}={1}:", i, arr1[i]);

            }
            Console.Write("\n");

            int max = arr1[0];
            int min = arr1[0];


            for (int i = 0; i < 3; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            Console.WriteLine("maximum element:" + max);
            Console.WriteLine("minimum element:" + min);

            Console.ReadKey();
        }
    }
}









