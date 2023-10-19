using System;
namespace program
{
    class vowel
    {
        public static void Main()
        {
            char op;
            Console.WriteLine("enter character");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("character is vowel");
                    break;
                default:
                    Console.WriteLine("character is  consonent");
                    break;
            }
            Console.ReadKey();
        }
    }
}
       