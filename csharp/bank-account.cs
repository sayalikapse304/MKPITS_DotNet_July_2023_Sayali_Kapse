﻿using System;
namespace program
{

    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int Balance { get; set; }
        public void display()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("account details of customer  :");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("account no : " + AccountNumber);
            Console.WriteLine("account Holder name : " + AccountHolderName);
            Console.WriteLine("Balance : " + Balance);
        }
        public void transfer(BankAccount ba)
        {
            Balance = Balance + ba.Balance;
            ba.Balance = 0;

        }
        public void showbalance()
        {
            Console.WriteLine("current balance for account no {0} is {1} ", AccountNumber, Balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 1;
            b1.AccountHolderName = "Sayali";
            b1.Balance = 10000;

            b1.display();

            BankAccount b2 = new BankAccount();
            b2.AccountNumber = 2;
            b2.AccountHolderName = "Santosh";
            b2.Balance = 5000;

            b2.display();

            b1.transfer(b2);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("balance after transaction ");
            Console.WriteLine("----------------------------------");

            b1.showbalance();
            b2.showbalance();
            Console.ReadKey();


        }
    }
}
