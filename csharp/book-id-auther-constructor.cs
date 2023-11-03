using System;


namespace program
{
    class Book
    {
        int bookid;
        string title, auther;
        int price;
        public Book()
        {
            bookid = 1;
            title = "power of mind";
            auther = "sayali";
            price = 550;
        }
        public void displaydata()
        {
            Console.WriteLine("bookid=" + bookid);
            Console.WriteLine("title=" + title);
            Console.WriteLine("auther=" + auther);
            Console.WriteLine("price=" + price);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.displaydata();
            Console.ReadLine();
        }
    }

}
