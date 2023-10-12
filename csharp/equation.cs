using System;
    namespace program
{
    class equ
    {
        public static void Main()
        {
            int x, y, z;
            float res1 = 0, res2 = 0;

            Console.WriteLine("Enter first number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter seconde number");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number");
            z = Convert.ToInt32(Console.ReadLine());
            res1 = (x + y) * z;
            res2 = x * y + y * z;
            Console.WriteLine("(x+y)*y is" + res1);
            Console.WriteLine("x*y + y*z is" + res2);
            Console.ReadKey();
        }
    }
}


      
