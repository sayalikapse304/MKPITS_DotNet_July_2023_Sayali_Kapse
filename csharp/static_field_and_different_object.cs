using System;
namespace program
{
    class Book
    {
        static string title;
        static Book()
        {
            title = "mkpits";
        }
        public void display()
        {
            Console.WriteLine("title:" + title);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.display();
            Book b2 = new Book();
            b2.display();
            Console.ReadKey();
        }
    }
}