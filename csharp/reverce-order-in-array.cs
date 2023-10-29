using System;
namespace program
{
    class num
    {
        public static void Main()
        {
            int[] num = new int[3];
            Console.WriteLine("Input the number of element to store in the array:3");
            Console.WriteLine("Input 3 number of element  in the array");

            for (int i = 0; i < 3; i++)
            {
                
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("element-{0}={1}:", i, num[i]);

            }
            Console.Write("\n");
            Console.WriteLine("the values store into the array are:");
            for (int i = 0; i < 3; i++)
            {

                Console.Write("{0} ", num[i]);
            }
            Console.Write("\n");
            Console.WriteLine("The value stored into the array in reverse are:");
            for (int i = 2; i >= 0; i--)
            {
                Console.Write(num[i]);
            }
            Console.ReadKey();
        }
    }
}
