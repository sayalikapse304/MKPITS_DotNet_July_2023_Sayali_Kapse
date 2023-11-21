using System;
namespace program
{
    interface bank
    {
        string deposit(int actno, int amt);
    }
    class account
    {
        public int actno;
        public int bal = 1000;
    }
    class saving : account, bank
    {
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposit successfully,bal is " + bal;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            bank b;
            b = new saving();
            string str = b.deposit(123, 300);
            Console.WriteLine(str);

        }
    }
}