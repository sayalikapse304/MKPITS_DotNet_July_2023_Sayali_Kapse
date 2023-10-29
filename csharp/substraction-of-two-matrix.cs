using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int i, j;
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];

            Console.Write("Input elements in the matrix 1 :\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            Console.Write("Input elements in the matrix 2 :\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\n matrix 1 is : \n");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            Console.Write("\n matrix 2 is : \n");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("{0}\t", arr2[i, j]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("substraction of 2 matrix is:\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
                }
            }
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}