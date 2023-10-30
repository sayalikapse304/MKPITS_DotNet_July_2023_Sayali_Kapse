using System;
using System.Xml.Linq;

namespace program
{
    class num
    {
        public static void Main()
        {
            

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

            int cnt = 0;
            for (int i = 0; i < 3; i++)
            {
                cnt = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                    {
                        if (arr1[i] == arr1[j])
                        {
                            cnt++;
                            break;
                        }
                    }
                }
                if (cnt == 0) 
                {
                    Console.WriteLine("Unique element is:" + arr1[i]);

                }
            }
            Console.ReadKey();
        }
    }
}









