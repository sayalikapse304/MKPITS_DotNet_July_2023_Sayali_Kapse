using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace program
{
    class num
    {
        public static void Main()
        {
            int temp= 0;

            int[] arr= new int[3];

            Console.WriteLine("Input the size of array:3");
            Console.WriteLine("Input 3 element  in the array");

            for (int i = 0; i < 3; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("element-{0}={1}", i, arr[i]);

            }
            Console.Write("\n");
            Console.WriteLine("Ascending order:\n");
            for(int i=0;i<3;i++)
            {
                for(int j=i+1;j<3;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
                Console.Write(arr[i]+"\t");
              
            }

 

            Console.ReadKey();
        }
    }
}









