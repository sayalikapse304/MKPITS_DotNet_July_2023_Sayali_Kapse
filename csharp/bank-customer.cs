using System;
using System.ComponentModel.DataAnnotations;

namespace program
{
    class Bank_customer
    {
        string name;
        int acc_num;
        int bal;
        int amt=500;
        int deposit;
        int withdraw;
        public void getdata(string name, int acc_num, int bal)
        {
            this.name = name;
            this.acc_num = acc_num;
            this.bal = bal;
            
             deposit = bal + amt;
             withdraw = bal - amt;
        }
        public void displaydata()
        {
            Console.WriteLine("deposit:" + deposit);
            Console.WriteLine("withdraw:" + withdraw);
        }
        }
    class program
    {
        static void Main(string[] args)
        {
            Bank_customer b1 = new Bank_customer();
            Console.WriteLine("enter customer name");
            string cn = Console.ReadLine();
            Console.WriteLine("enter account num");
            int an = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account bal");
            int b = Convert.ToInt32(Console.ReadLine());
            
            b1.getdata(cn, an, b);
            b1.displaydata();
            Console.ReadLine();


        }
    }
        
}