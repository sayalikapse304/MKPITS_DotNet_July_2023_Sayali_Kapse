using System;
namespace program
{ 
class Program
{
    static void Main(string[] args)
    {

            int n;

        Console.WriteLine("enter limit");
           
        n = Convert.ToInt32(Console.ReadLine()); 
        int i= 1;
        int j = 1;

            do
            {
                j = 1;


                while (j <= n)
                {
                    Console.Write("{0}*{1}={2}", j,i, (i * j));
                    Console.Write("\t");

                    j++;

                }
                Console.WriteLine();
                i++;
            }
            while (i <= 10);
               
           



        Console.ReadKey();

    }
}
}

