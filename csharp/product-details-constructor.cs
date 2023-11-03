using System;
namespace program
{
    class Product
    {
        int productid;
        string productname;
        int price;
        int quantity;

        public Product()
        {
            productid = 1234;
            productname = "santoor soap";
            price = 35;
            quantity = 5;
        }
        public void displaydata()
        {
            Console.WriteLine("productid:" + productid);
            Console.WriteLine("productname:" + productname);
            Console.WriteLine("price:" + price);
            Console.WriteLine("quantity:" + quantity);
        }
    }
    class program
    {
        static void Main(string[] args)
        {

            Product p = new Product();
            p.displaydata();
            Console.ReadKey();
        }
    }
}