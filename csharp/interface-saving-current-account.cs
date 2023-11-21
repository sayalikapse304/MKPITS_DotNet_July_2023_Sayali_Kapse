using System;
using System.Diagnostics;

namespace program
{
    interface bank
    {
        string deposit(int acctno, int amt);
    }
    class saving : bank
    {
        int acctno;
        int bal = 1000;
        int interest = 300;
        public string deposit(int acctno, int amt)
        {
            this.acctno = acctno;
            bal = bal + amt + interest;
            return "actno:" + acctno + "bal is:" + bal;
        }
    }
    class current : bank
    {
        int acctno;
        int bal = 1000;

        public string deposit(int acctno, int amt)
        {
            this.acctno = acctno;
            bal = bal + amt;
            return "actno:" + acctno + "bal is:" + bal;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            bank b = null;
            Console.WriteLine("enter saving or current");
            string acttype = Console.ReadLine();

            switch (acttype)
            {
                case "saving":
                    b = new saving();
                    break;


                case "current":
                    b = new current();
                    break;
            }
            string res = b.deposit(1233, 400);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

                    

            


            



            