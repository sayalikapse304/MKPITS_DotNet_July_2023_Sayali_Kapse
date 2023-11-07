using System;
namespace program
{
    class Calculation
    {
        public void substraction(int n1, int n2)
        {
            int res = n1-n2;
            Console.WriteLine("substraction of 2 int is:" + res);
        }
        public void substraction(float n1, float n2)
        {
            float res = n1-n2;
            Console.WriteLine("substraction of 2 float is:" + res);
        }
        class program
        {
            public static void Main(string[] args)
            {
                Calculation c = new Calculation();
                c.substraction(5, 2);
                c.substraction(8, 2);
                Console.ReadKey();
            }
        }
    }
}
            
