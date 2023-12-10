using System;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {

            int P, T;
            float R, SI;
            Console.Write("Enter Amount :");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate :");
            R = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Time :");
            T = Convert.ToInt32(Console.ReadLine());
            SI = P * R * T / 100;
            Console.WriteLine("Interest is :{0}", SI);
            Console.ReadKey();

            Console.ReadLine();
        }
    }
}