﻿using System;
namespace program
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        
        public Book(int bookid, string title, string author, int price)
        {
            
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void display()
        {
            Console.WriteLine("-------------------------------------------");
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
            Console.WriteLine("enter bookid");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            string t1 = Console.ReadLine();
            Console.WriteLine("enter author");
            string a1 = Console.ReadLine();
            Console.WriteLine("enter price");
            int p1 = Convert.ToInt32(Console.ReadLine());

            Book b2 = new Book(b1, t1, a1, p1); 
            b2.display();
        }
    }
}


