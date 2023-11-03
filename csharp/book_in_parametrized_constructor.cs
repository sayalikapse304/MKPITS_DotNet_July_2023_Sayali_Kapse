using System;
namespace program
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        public Book()
        {
            
            Console.WriteLine("constructor with no parameters called default constructor");
            bookid = 123;
            title = "velocity";
            author = "sayali kapse";
            price = 2000;
        }

        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("constructor with  parameters called parametrized constructor");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id : " + bookid);
            Console.WriteLine("title : " + title);
            Console.WriteLine("author : " + author);
            Console.WriteLine("price : " + price);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.display();


            Book b2 = new Book(123, "power", "Mayuri", 500);
            b2.display();
        }
    }
}