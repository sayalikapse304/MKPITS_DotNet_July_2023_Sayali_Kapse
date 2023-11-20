using System;
namespace program
{
    abstract class Account
    {

        public int bal = 1000;
        public abstract void deposit(int amt);
        public abstract void withdrawl(int amt);

        public void showbalance()
        {
            Console.WriteLine("balance is " + bal);
        }
    }
    class current : Account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("amount deposited without interest bal is" + bal);
        }
        public override void withdrawl(int amt)
        {
            bal = bal - amt;
        }
    }
    class saving : Account
    {
        public override void deposit(int amt)
        {
            int interest = 300;
            bal = bal + amt + interest;
            Console.WriteLine("amount deposited withinterest bal is" + bal);
        }
        public override void withdrawl(int amt)
        {

            bal = bal - amt;
        }
    }
    class program
    {
        static void Main(string[] args)
        {

            Account act = null;
            Console.WriteLine("enter amount");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter account type saving or current");
            string acctype = Console.ReadLine();

            Console.WriteLine("enter deposit or withdrawl");
            string tt = Console.ReadLine();


            if (acctype == "saving")
            {
                act = new saving();
            }
            else if (acctype == "current")
            {
                act = new current();
            }
            if (tt =="deposit")
            {
                act.deposit(amt);
            }
            else if (tt =="withdrawl")
            {
                act.withdrawl(amt);
            }
            act.showbalance();
            Console.ReadLine();
        }
    }
}
      