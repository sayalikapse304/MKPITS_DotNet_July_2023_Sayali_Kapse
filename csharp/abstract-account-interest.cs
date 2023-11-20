using System;
namespace program
{
    abstract class Account
    {
        public int acctno;
        public int bal = 1000;
        public abstract void deposit(int amt);

        public void showbalance()
        {
            Console.WriteLine("balance amount for account no {0} is {1}", acctno, bal);
        }
    }
    class current : Account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;
        }
    }
    class saving : Account
    {
        public override void deposit(int amt)
        {
            int interest = 300;
            bal = bal + amt + interest;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter account no");
            int acctno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter amount to be deposit");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter account type saving or current");
            string acctype = Console.ReadLine();

            Account act = null;

            if (acctype == "saving")
            {
                act = new saving();
            }
            else if (acctype == "current")
            {
                act = new current();
            }
            act.acctno = acctno;
            act.deposit(amt);
            act.showbalance();
        }
    }

}