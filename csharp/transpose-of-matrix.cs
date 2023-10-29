using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int i, j;
            int[,] arr1 = new int[2, 2];
            

            Console.Write("Input elements in the matrix  :\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            
            Console.Write("\n matrix  is : \n");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Transpose of matrix:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(arr1[j,i] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}