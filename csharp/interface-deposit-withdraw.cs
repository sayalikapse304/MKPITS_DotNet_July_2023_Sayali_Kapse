using System;
namespace program
{
    interface bank
    {
        string deposit(int actno, int amt);
        string withdrawl(int actno, int amt);
    }
    class account
    {
        public int actno;
        public int bal = 1000;

        public string showbalance()
        {
            return "bal is " + bal;
        }
    }
    class saving : account, bank
    {
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposit successefully ,bal is " + bal;
        }

        public string withdrawl(int actno, int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "withdrawl successefully ,bal is " + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            saving b;
            b = new saving();
            string res = b.deposit(1122, 500);
            Console.WriteLine(res);

            res = b.withdrawl(1233, 500);
            Console.WriteLine(res);
            Console.WriteLine(b.showbalance());

        }
    }
}

       