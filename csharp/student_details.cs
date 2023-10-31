using System;
namespace program
{
     
        class Book
        {
            string title;
            string author;
            int publicationYear;

            public void getdata(string title, string author, int publicationyear)
            {
                this.author = author;
                this.title = title;
                this.publicationYear = publicationyear;
            }
            public void displaydata()
            {
                Console.WriteLine("Author :" + author);
                Console.WriteLine("title :" + title);
                Console.WriteLine("publicationyear : " + publicationYear);
            }

        }
    class program
    { 
        static void Main(string[] args)
        {

            Book[] bookid = new Book[3];
            bookid[0] = new Book();
            bookid[1] = new Book();
            bookid[2] = new Book();
            string auth = null;
            string tit = null;
            int publication = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Author");
                auth = Console.ReadLine();

                Console.WriteLine("Enter title");
                tit = Console.ReadLine();

                Console.WriteLine("Enter publicationYear");
                publication = Convert.ToInt32(Console.ReadLine());
                bookid[i].getdata(auth, tit, publication);
            }

            for (int i = 0; i < 3; i++)
            {
                bookid[i].displaydata();

            }
            Console.ReadKey();



        }
    }
}

