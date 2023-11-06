using System;
namespace program
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "csharp";
            author = "swami";
            price = 500;
        }
        public void getdata(int bookid)
        {
            this.bookid = bookid;
            getdata(bookid, "html");
        }
        public void getdata(int bookid, string title)
        {
            this.bookid = bookid;
            this.title = title;
            getdata(bookid, title, "sara");
        }
        public void getdata(int bookid, string title, string author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;

            getdata(bookid, title, author, 600);
        }
        public void getdata(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("bookid:" + bookid);
            Console.WriteLine("title:" + title);
            Console.WriteLine("author:" + author);
            Console.WriteLine("price:" + price);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata(800);
            b.display();
            Console.WriteLine();
        }
    }
}

       


  