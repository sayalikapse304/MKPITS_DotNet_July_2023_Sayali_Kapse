using System;
namespace program
{
    class Calculate
    {
        public void addition(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("addition of 2 int is:" + res);
        }
        public void addition(float n1, float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("addition of 2 float is:" + res);
        }
        class program
        {
            public static void Main(string[] args)
            {
                Calculate c = new Calculate();
                c.addition(4, 2);
                c.addition(2.3f, 2.5f);
                Console.ReadKey();
            }
        }
    }
}
    