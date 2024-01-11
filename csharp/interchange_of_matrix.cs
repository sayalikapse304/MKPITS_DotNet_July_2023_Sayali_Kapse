using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class interchangecol
{
    int m, n;
    int[,] a;
    public interchangecol(int x, int y)
    {
        m = x;
        n = y;
        a = new int[m, n];
    }
    public void readmatrix()
    {
        Console.WriteLine("Enter the Elements : ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("a[{0},{1}] =", i, j);
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    public void printmax()
    {
        Console.WriteLine("Given Matrix : ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}\t", a[i, j]);
            }
            Console.WriteLine();
        }
    }
    public void interchange()
    {
        Console.WriteLine("Enter the Column Number to Interchange : ");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Column Number with which " +
                          "Interchange is to be Accomplished :");
        int j = Convert.ToInt32(Console.ReadLine());
        for (int k = 0; k < m; k++)
        {
            int temp = a[k, i - 1];
            a[k, i - 1] = a[k, j - 1];
            a[k, j - 1] = temp;
        }
    }
    public static void Main()
    {
        int x, y;
        interchangecol obj;
        Console.Write("Enter the Number of Rows :");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Number of Columns :");
        y = Convert.ToInt32(Console.ReadLine());
        obj = new interchangecol(x, y);
        obj.readmatrix();
        obj.printmax();
        obj.interchange();
        obj.printmax();
        Console.ReadLine();
    }
}