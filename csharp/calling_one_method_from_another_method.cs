using System;
namespace program
{
    class Book
    {
        string title, author;
        public void getdata(string title)
        {
            getdata(title, "sayali");
        }
        public void getdata(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
        public void display()
        {
            Console.WriteLine("title:" + title);
            Console.WriteLine("author:" + author);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.getdata("html");
            b1.display();
            Console.ReadLine();
        }
    }
}