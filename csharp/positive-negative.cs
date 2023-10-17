using System;

namespace program
{
    class positive_negative
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine(+num + " " + "is a positive number");
            }
            else
            { 
                Console.WriteLine(+num + " " + "is a negative number");
        }
        Console.ReadKey();
       
}
}
}