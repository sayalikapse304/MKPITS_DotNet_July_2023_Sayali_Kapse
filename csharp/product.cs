using System;
using System.ComponentModel.Design;

namespace program
{
    class Product
    {
        string name;
        int price;
        int stockQuantity;
        public void getdata(string name, int price, int stockQuantity)
        {
            this.name = name;
            this.price = price;
            this.stockQuantity = stockQuantity;

        }
        public void display()
        {
            Console.WriteLine("product name:" + name);
            Console.WriteLine("price:" + price);
            Console.WriteLine("Quntity:" + stockQuantity);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            string name;
            int itme, price;
            int total;
            int stock = 20;

            Console.WriteLine("enter product name:");
            name = Console.ReadLine();
            Console.WriteLine("How much you buy:");
            itme = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Amount:");
            price = Convert.ToInt32(Console.ReadLine());

            if (itme > 0 && itme < stock)
            {
                int remaingstock = stock - itme;
                total = price * itme;

                p.getdata(name, price, itme);
                p.display();
                Console.WriteLine("total price you purches:" + total);
                Console.WriteLine("Reamaingstock:" + remaingstock);
            }
            else
            {
                Console.WriteLine("Insufficient in stock");
            }
                Console.ReadLine();
            }
        }
    }

        
    