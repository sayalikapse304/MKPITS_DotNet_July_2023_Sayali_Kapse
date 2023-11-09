using System;
namespace program
{
    class Book
    {
        public static int bookid;
        public static void display()
        {
            Console.WriteLine("hello from static display method");
        }
    }
    class program
    {


        static void Main(string[] args)
        {
            Book.bookid = 19;
            program p = new program();
            p.Main();
            Console.WriteLine("bookid:" + Book.bookid);
        }
        void Main()
        {

            Console.WriteLine("hello from another main method");
        }
    }
}

    
