using System;

namespace program
{
    class number
    {
        static int account(int actno, int amount)
        {
            int result = 0;

            int bal = 1000;

            int deposit = bal+amount;
            int withdrawl = bal-amount;

            Console.WriteLine("deposit=" + deposit);
            Console.WriteLine("withdrawl=" + withdrawl);
            return result;
        }
        static void Main(string[] args)
        {
            int actnum, amt;
            Console.WriteLine("enter account number");
            actnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter amt ");
            amt = Convert.ToInt32(Console.ReadLine());

            int res = account(actnum, amt);
            Console.ReadKey();
        }
    }
}





        
    


