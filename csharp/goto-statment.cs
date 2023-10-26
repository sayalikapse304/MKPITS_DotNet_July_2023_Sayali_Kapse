using System;
namespace program
{
    class even
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) goto Even;
            Console.WriteLine("odd no");
            goto End;

        Even:
            Console.WriteLine("even no");
        End:
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}