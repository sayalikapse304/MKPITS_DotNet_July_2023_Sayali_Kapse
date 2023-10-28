using System;
namespace program
{
    class num
    {
        public static void Main()
        {
            
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
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
            Console.WriteLine("the values store into the array are:");
            for (int i = 0; i < 3; i++)
            {

                Console.Write("{0} ", arr1[i]);
            }
            Console.Write("\n");
            Console.WriteLine("element of array1:");
            for (int i = 0; i < 3; i++)
            {
                arr2[i]= arr1[i];
                Console.Write(  arr1[i]);
            }
            Console.Write("\n");
            Console.WriteLine("Element copied in array2:");
            for(int i=0;i<3;i++)
            {
                
                    Console.Write( arr2[i]);
                }
            

            Console.ReadKey();
        }
    }
}
