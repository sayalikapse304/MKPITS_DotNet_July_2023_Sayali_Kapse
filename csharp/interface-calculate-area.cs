using System;
namespace program
{
    interface shape
    {
       void calculate(int n1, int n2);

    }

    class rectangle : shape
    {

       public void calculate(int n1, int n2)
        {

            int area = n1 * n2;
            Console.WriteLine("area of rectangle:" + area);
        }

    }
    class circal : shape
    {

        public void calculate(int n1, int n2)
        {

            float area = 0.5f * n1 * n2;
            Console.WriteLine("area of circal:" + area);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter n2");
            int n2 = Convert.ToInt32(Console.ReadLine());

            shape r = new rectangle();
            r.calculate(n1, n2);
            shape c = new circal();
            c.calculate(n1, n2);



            Console.ReadKey();

        }
    }
}





