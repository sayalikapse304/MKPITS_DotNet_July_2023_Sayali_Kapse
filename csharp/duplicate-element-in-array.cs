using System;
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

            
            for (int i = 0; i < 3; i++)
            {
                for (int j = i+1; j < 3; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        cnt++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements found in the array is:"+cnt);


            Console.ReadKey();
        }
    }
}









