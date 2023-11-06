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
      public  static void display()
        {
            Console.WriteLine("title:" + title);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Book.display();
            Console.ReadKey();
        }
    }
}