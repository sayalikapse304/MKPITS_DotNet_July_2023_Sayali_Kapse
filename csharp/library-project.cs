using System;
namespace program
{
    class Author
    {
        public string AuthorName { get; set; }

        public Author(string authorName)
        {
            AuthorName = authorName;
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public Author Author { get; set; }

        public Book(string title, string isbn, Author author)
        {
            Title = title;
            ISBN = isbn;
            Author = author;
        }

    }