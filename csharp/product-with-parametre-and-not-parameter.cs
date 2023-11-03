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
        public Product(int productid,string productname,int price,int quantity)
        {
            this.productid = productid;
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;


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
            Console.WriteLine("------------------------------------");
            Product p2 = new Product(123,"milk",200,2);
            p2.displaydata();
            Console.ReadKey();
        }
    }
}