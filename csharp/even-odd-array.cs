using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace program
{
    class num
    {
        public static void Main()
        {


            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];

            Console.WriteLine("Input the number of element to store in the array:3");
            Console.WriteLine("Input 5 number of element  in the array");

            for (int i = 0; i < 5; i++)
            {

                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("\n");
           

            int k = 0;
            int j = 0;

            for (int i = 0; i < 5; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
                Console.Write("Even number:\n");

            
            for (int i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
            Console.Write("\n");
            Console.Write("Odd number:\n");
            for ( int i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }

        }
    }
}









