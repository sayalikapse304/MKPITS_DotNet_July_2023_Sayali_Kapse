using System;
using System.Security.AccessControl;

namespace program
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual String deposit(int actno, int amount)
        {
            return "deposit method of account class";
        }
        public virtual String withdraw(int actno, int amount)
        {
            return "withdraw method of account class";
        }
        public String dshowbalance()
        {
            return "balance amount : " + balance;
        }
        public String wshowbalance()
        {
            return "balance amount : " + balance;
        }
    }

    class Current : Account
    {

        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "amount deposited successfully without interest in current class";
        }
        public override string withdraw(int actno, int amount)
        {
            balance = 1000;
            this.actno = actno;
            balance = balance - amount;
            if (amount > balance)
            {
                return "Insufficient bal for withdraw from current account";
            }
            else
            {
                return "withdrawl successfully in current account";
            }
        }
    }

    class Saving : Account
    {

        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int interest = 500;
            balance = balance + amount + interest;
            return "amount deposited successfully with interest in saving class";
        }
        public override string withdraw(int actno, int amount)
        {
            this.actno = actno;
            int interest = 500;
            balance = balance - amount;
            if (amount > balance)
            {
                return "Insufficient bal for withdraw from saving account";
            }
            else
            {
                return "withdrawl successfully in saving account";
            }
        }
    }
    public class TestBase
    {
        public static void Main()
        {


            Console.WriteLine("enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter saving or current account");
            string acttype = Console.ReadLine();
            Console.WriteLine("enter deposit or withdrawl");
            string tt = Console.ReadLine();

            Account act = null;
            if (acttype == "saving")
            {
                act = new Saving();
            }
            else if (acttype == "current")
            {
                act = new Current();
            }
            if (tt == "deposit")
            {
                string res = act.deposit(actno, amt);

                string res1 = act.dshowbalance();
                Console.WriteLine(res);
                Console.WriteLine(res1);
            }
            else if(tt=="withdraw")
            {
                string res2 = act.withdraw(actno, amt);

                string res3 = act.wshowbalance();
                Console.WriteLine(res2);
                Console.WriteLine(res3);
            }
            Console.ReadKey();


        }
    }
}

            

       
          

