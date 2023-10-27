using System;
namespace program
{
    class variable
    {
        static void Main(string[] args)
        {
            double[] num = new double[3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number");
                num[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}", num[i]);
            }
            Console.ReadKey();
        }
    }
}