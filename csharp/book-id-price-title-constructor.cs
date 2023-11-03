using System;
namespace program
{
    class Book
    {
        int bookid;
        String title, author;
        int price;
        
        public Book()
        {
            bookid = 1;
            title = "oracle";
            author = "james";
            price = 200;
        }
        
        public Book(int bookid, String title, String author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Console.WriteLine("-----------------book1 details ----------");
            Book b1 = new Book(111, "csharp", "martin", 2000); 
            b1.display();

            Console.WriteLine("-----------------book1 details ----------");
            Console.WriteLine("enter bookid");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            String title = Console.ReadLine();
            Console.WriteLine("enter author");
            String author = Console.ReadLine();
            Console.WriteLine("enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------book2 details ----------");
            Book b2 = new Book(id, title, author, price);
            b2.display();

            Console.ReadLine();

        }
    }
}